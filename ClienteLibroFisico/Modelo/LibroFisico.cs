using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClienteLibroFisico.Modelo
{
    /// <summary>
    /// Clase estructural del cliente: representa un libro físico tal como lo devuelve el servidor GraphQL.
    /// </summary>
    public class LibroFisico
    {
        [JsonPropertyName("isbn")]
        public string Isbn { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("autor")]
        public string Autor { get; set; }

        [JsonPropertyName("precio")]
        public double Precio { get; set; }

        [JsonPropertyName("numeroPaginas")]
        public int NumeroPaginas { get; set; }

        [JsonPropertyName("fechaImpresion")]
        public DateTime FechaImpresion { get; set; }

        /// <summary>Valor del enum del servidor: "BLANDA" o "DURA".</summary>
        [JsonPropertyName("tipoTapa")]
        public string TipoTapa { get; set; }

        [JsonPropertyName("totalPagar")]
        public double TotalPagar { get; set; }
    }

    /// <summary>Datos que se envían al servidor para crear un libro físico.</summary>
    public class LibroFisicoInput
    {
        [JsonPropertyName("isbn")]
        public string Isbn { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("autor")]
        public string Autor { get; set; }

        [JsonPropertyName("precio")]
        public double Precio { get; set; }

        [JsonPropertyName("numeroPaginas")]
        public int NumeroPaginas { get; set; }

        /// <summary>Fecha en formato ISO-8601 "yyyy-MM-ddTHH:mm:ss" (scalar LocalDateTime del servidor).</summary>
        [JsonPropertyName("fechaImpresion")]
        public string FechaImpresion { get; set; }

        [JsonPropertyName("tipoTapa")]
        public string TipoTapa { get; set; }
    }

    /// <summary>Datos que se envían al servidor para actualizar un libro físico (el ISBN no cambia).</summary>
    public class LibroFisicoUpdateInput
    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("autor")]
        public string Autor { get; set; }

        [JsonPropertyName("precio")]
        public double Precio { get; set; }

        [JsonPropertyName("numeroPaginas")]
        public int NumeroPaginas { get; set; }

        [JsonPropertyName("fechaImpresion")]
        public string FechaImpresion { get; set; }

        [JsonPropertyName("tipoTapa")]
        public string TipoTapa { get; set; }
    }

    /// <summary>Respuesta GraphQL con un solo libro (se usa el alias "libro" en todas las consultas).</summary>
    public class RespuestaLibro
    {
        [JsonPropertyName("libro")]
        public LibroFisico Libro { get; set; }
    }

    /// <summary>Respuesta GraphQL con una lista de libros (alias "libros").</summary>
    public class RespuestaLibros
    {
        [JsonPropertyName("libros")]
        public List<LibroFisico> Libros { get; set; }
    }
}
