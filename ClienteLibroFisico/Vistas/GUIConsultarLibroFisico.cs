using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClienteLibroFisico.Modelo;
using ClienteLibroFisico.Servicios;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>Caso de uso: Consultar UN libro físico a partir de su ISBN.</summary>
    [DesignerCategory("Form")]
    public partial class GUIConsultarLibroFisico : Form
    {
        private readonly LibroFisicoService servicio = new LibroFisicoService();

        public GUIConsultarLibroFisico()
        {
            InitializeComponent();
            EstiloVentana.Aplicar(this, lblEncabezado);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            LimpiarResultado();
            if (string.IsNullOrWhiteSpace(txtIsbnBuscar.Text))
            {
                errorProvider.SetError(txtIsbnBuscar, "Ingrese el ISBN a consultar.");
                return;
            }

            btnBuscar.Enabled = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                LibroFisico libro = await servicio.BuscarPorIsbnAsync(txtIsbnBuscar.Text);
                if (libro == null)
                {
                    Formato.Aviso(this, "No existe un libro físico con el ISBN " + txtIsbnBuscar.Text.Trim() + ".");
                    return;
                }
                Mostrar(libro);
            }
            catch (ServicioException ex)
            {
                Formato.Error(this, ex.Message);
            }
            finally
            {
                btnBuscar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void Mostrar(LibroFisico libro)
        {
            txtIsbn.Text = libro.Isbn;
            txtTitulo.Text = libro.Titulo;
            txtAutor.Text = libro.Autor;
            txtPrecio.Text = Formato.Moneda(libro.Precio);
            txtPaginas.Text = libro.NumeroPaginas.ToString();
            txtFechaImpresion.Text = Formato.Fecha(libro.FechaImpresion);
            txtTipoTapa.Text = TiposTapa.Nombre(libro.TipoTapa);
            txtTotalPagar.Text = Formato.Moneda(libro.TotalPagar);
        }

        private void LimpiarResultado()
        {
            foreach (Control c in grpResultado.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txtIsbnBuscar.Clear();
            LimpiarResultado();
            txtIsbnBuscar.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
