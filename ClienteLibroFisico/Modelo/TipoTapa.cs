using System.Collections.Generic;

namespace ClienteLibroFisico.Modelo
{
    /// <summary>Opción de tipo de tapa: valor que entiende el servidor + nombre para mostrar.</summary>
    public class TipoTapaOpcion
    {
        public string Valor { get; private set; }
        public string Nombre { get; private set; }

        public TipoTapaOpcion(string valor, string nombre)
        {
            Valor = valor;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }

    /// <summary>Valores del enum TipoTapa del servidor.</summary>
    public static class TiposTapa
    {
        public const string BLANDA = "BLANDA";
        public const string DURA = "DURA";

        public static List<TipoTapaOpcion> Opciones()
        {
            return new List<TipoTapaOpcion>
            {
                new TipoTapaOpcion(BLANDA, "Tapa blanda"),
                new TipoTapaOpcion(DURA, "Tapa dura")
            };
        }

        public static string Nombre(string valor)
        {
            if (valor == BLANDA) return "Tapa blanda";
            if (valor == DURA) return "Tapa dura";
            return valor;
        }
    }
}
