using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ClienteLibroFisico.Modelo;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;

namespace ClienteLibroFisico.Servicios
{
    /// <summary>Error devuelto por el servidor o de comunicación, con un mensaje apto para el usuario.</summary>
    public class ServicioException : Exception
    {
        public ServicioException(string mensaje) : base(mensaje) { }
    }

    /// <summary>
    /// Encapsula todas las llamadas GraphQL al microservicio de libros físicos.
    /// Las ventanas (Vistas) solo usan esta clase; no arman consultas GraphQL.
    /// </summary>
    public class LibroFisicoService
    {
        public const string URL_SERVIDOR = "http://localhost:8081/graphql";

        // Campos que se piden en todas las consultas (TODA la información del objeto).
        private const string CAMPOS = @"
            isbn
            titulo
            autor
            precio
            numeroPaginas
            fechaImpresion
            tipoTapa
            totalPagar";

        private static readonly GraphQLHttpClient cliente =
            new GraphQLHttpClient(URL_SERVIDOR, new SystemTextJsonSerializer());

        // ---------------- Consultas (Query) ----------------

        /// <summary>Lista todos los libros físicos.</summary>
        public async Task<List<LibroFisico>> ListarAsync()
        {
            var request = new GraphQLRequest
            {
                Query = "query listar { libros: librosFisicos {" + CAMPOS + " } }"
            };
            var respuesta = await Enviar(() => cliente.SendQueryAsync<RespuestaLibros>(request));
            return respuesta.Libros ?? new List<LibroFisico>();
        }

        /// <summary>
        /// Lista filtrando en el servidor por autor (parcial) y/o tipo de tapa.
        /// Un parámetro null o vacío no se aplica.
        /// </summary>
        public async Task<List<LibroFisico>> FiltrarAsync(string autor, string tipoTapa)
        {
            var request = new GraphQLRequest
            {
                Query = @"query filtrar($autor: String, $tipoTapa: TipoTapa) {
                            libros: librosFisicosFiltrados(autor: $autor, tipoTapa: $tipoTapa) {" + CAMPOS + @" }
                          }",
                Variables = new
                {
                    autor = string.IsNullOrWhiteSpace(autor) ? null : autor.Trim(),
                    tipoTapa = string.IsNullOrWhiteSpace(tipoTapa) ? null : tipoTapa
                }
            };
            var respuesta = await Enviar(() => cliente.SendQueryAsync<RespuestaLibros>(request));
            return respuesta.Libros ?? new List<LibroFisico>();
        }

        /// <summary>Busca un solo libro por ISBN. Devuelve null si no existe.</summary>
        public async Task<LibroFisico> BuscarPorIsbnAsync(string isbn)
        {
            var request = new GraphQLRequest
            {
                Query = "query consultar($isbn: ID!) { libro: libroFisicoPorIsbn(isbn: $isbn) {" + CAMPOS + " } }",
                Variables = new { isbn = isbn.Trim() }
            };
            var respuesta = await Enviar(() => cliente.SendQueryAsync<RespuestaLibro>(request));
            return respuesta.Libro;
        }

        // ---------------- Mutaciones (Mutation) ----------------

        public async Task<LibroFisico> CrearAsync(LibroFisicoInput input)
        {
            var request = new GraphQLRequest
            {
                Query = "mutation crear($input: LibroFisicoInput!) { libro: crearLibroFisico(input: $input) {" + CAMPOS + " } }",
                Variables = new { input = input }
            };
            var respuesta = await Enviar(() => cliente.SendMutationAsync<RespuestaLibro>(request));
            return respuesta.Libro;
        }

        public async Task<LibroFisico> ActualizarAsync(string isbn, LibroFisicoUpdateInput input)
        {
            var request = new GraphQLRequest
            {
                Query = @"mutation actualizar($isbn: ID!, $input: LibroFisicoUpdateInput!) {
                            libro: actualizarLibroFisico(isbn: $isbn, input: $input) {" + CAMPOS + @" }
                          }",
                Variables = new { isbn = isbn, input = input }
            };
            var respuesta = await Enviar(() => cliente.SendMutationAsync<RespuestaLibro>(request));
            return respuesta.Libro;
        }

        /// <summary>Elimina el libro y devuelve los datos del libro eliminado.</summary>
        public async Task<LibroFisico> EliminarAsync(string isbn)
        {
            var request = new GraphQLRequest
            {
                Query = "mutation eliminar($isbn: ID!) { libro: eliminarLibroFisico(isbn: $isbn) {" + CAMPOS + " } }",
                Variables = new { isbn = isbn }
            };
            var respuesta = await Enviar(() => cliente.SendMutationAsync<RespuestaLibro>(request));
            return respuesta.Libro;
        }

        // ---------------- Utilidades ----------------

        /// <summary>Convierte una fecha al formato que espera el scalar LocalDateTime del servidor.</summary>
        public static string FormatoFechaServidor(DateTime fecha)
        {
            return fecha.ToString("yyyy-MM-dd'T'HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>Envía la petición y convierte errores GraphQL o de red en ServicioException.</summary>
        private static async Task<T> Enviar<T>(Func<Task<GraphQLResponse<T>>> peticion)
        {
            GraphQLResponse<T> respuesta;
            try
            {
                respuesta = await peticion();
            }
            catch (GraphQLHttpRequestException ex)
            {
                throw new ServicioException("El servidor respondió con un error (" + ex.StatusCode + ").");
            }
            catch (HttpRequestException)
            {
                throw new ServicioException("No fue posible conectarse con el servidor en " + URL_SERVIDOR +
                                            ".\nVerifique que el microservicio esté en ejecución.");
            }
            catch (TaskCanceledException)
            {
                throw new ServicioException("El servidor tardó demasiado en responder.");
            }

            if (respuesta.Errors != null && respuesta.Errors.Length > 0)
            {
                string mensajes = string.Join("\n", respuesta.Errors.Select(e => e.Message));
                throw new ServicioException(mensajes);
            }
            return respuesta.Data;
        }
    }
}
