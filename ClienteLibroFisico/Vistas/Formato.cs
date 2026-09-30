using System;
using System.Globalization;
using System.Windows.Forms;
using ClienteLibroFisico.Modelo;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>Utilidades de presentación compartidas por las ventanas.</summary>
    internal static class Formato
    {
        public static readonly CultureInfo Colombia = new CultureInfo("es-CO");
        public const string FORMATO_FECHA = "dd/MM/yyyy HH:mm";

        public static string Moneda(double valor)
        {
            return valor.ToString("C2", Colombia);
        }

        public static string Fecha(DateTime fecha)
        {
            return fecha.ToString(FORMATO_FECHA, CultureInfo.InvariantCulture);
        }

        /// <summary>Texto con TODA la información del libro, para confirmaciones.</summary>
        public static string Resumen(LibroFisico libro)
        {
            return "ISBN: " + libro.Isbn +
                   "\nTítulo: " + libro.Titulo +
                   "\nAutor: " + libro.Autor +
                   "\nPrecio: " + Moneda(libro.Precio) +
                   "\nNúmero de páginas: " + libro.NumeroPaginas +
                   "\nFecha de impresión: " + Fecha(libro.FechaImpresion) +
                   "\nTipo de tapa: " + TiposTapa.Nombre(libro.TipoTapa) +
                   "\nTotal a pagar: " + Moneda(libro.TotalPagar);
        }

        public static void Error(IWin32Window owner, string mensaje)
        {
            MessageBox.Show(owner, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Aviso(IWin32Window owner, string mensaje)
        {
            MessageBox.Show(owner, mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Exito(IWin32Window owner, string mensaje)
        {
            MessageBox.Show(owner, mensaje, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
