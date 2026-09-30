using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClienteLibroFisico.Modelo;
using ClienteLibroFisico.Servicios;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>
    /// Caso de uso: Eliminar libro físico.
    /// Primero se busca el libro y se muestra TODA su información; luego se confirma la eliminación.
    /// </summary>
    [DesignerCategory("Form")]
    public partial class GUIEliminarLibroFisico : Form
    {
        private readonly LibroFisicoService servicio = new LibroFisicoService();
        private LibroFisico libroEncontrado;

        public GUIEliminarLibroFisico()
        {
            InitializeComponent();
            EstiloVentana.Aplicar(this, lblEncabezado);
            txtIsbnBuscar.TextChanged += txtIsbnBuscar_TextChanged;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Reiniciar();
            if (string.IsNullOrWhiteSpace(txtIsbnBuscar.Text))
            {
                errorProvider.SetError(txtIsbnBuscar, "Ingrese el ISBN del libro a eliminar.");
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
                libroEncontrado = libro;
                Mostrar(libro);
                btnEliminar.Enabled = true;
                AcceptButton = btnEliminar;
                btnEliminar.Focus();
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

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (libroEncontrado == null)
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show(this,
                "¿Está seguro de eliminar el siguiente libro físico?\n\n" + Formato.Resumen(libroEncontrado) +
                "\n\nEsta acción no se puede deshacer.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            btnEliminar.Enabled = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                LibroFisico eliminado = await servicio.EliminarAsync(libroEncontrado.Isbn);
                Formato.Exito(this, "Se eliminó el libro \"" + eliminado.Titulo + "\" (ISBN " + eliminado.Isbn + ").");
                txtIsbnBuscar.Clear();
                Reiniciar();
                txtIsbnBuscar.Focus();
            }
            catch (ServicioException ex)
            {
                Formato.Error(this, ex.Message);
                btnEliminar.Enabled = true;
            }
            finally
            {
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

        /// <summary>Borra el resultado y deshabilita Eliminar hasta una nueva búsqueda.</summary>
        private void Reiniciar()
        {
            libroEncontrado = null;
            btnEliminar.Enabled = false;
            AcceptButton = btnBuscar;
            foreach (Control c in grpResultado.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        // Si el usuario cambia el ISBN después de buscar, se obliga a buscar de nuevo.
        private void txtIsbnBuscar_TextChanged(object sender, EventArgs e)
        {
            if (libroEncontrado != null)
            {
                Reiniciar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txtIsbnBuscar.Clear();
            Reiniciar();
            txtIsbnBuscar.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
