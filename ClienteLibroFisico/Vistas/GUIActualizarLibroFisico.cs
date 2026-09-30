using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ClienteLibroFisico.Modelo;
using ClienteLibroFisico.Servicios;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>
    /// Caso de uso: Actualizar libro físico.
    /// Primero se busca el libro y se muestra TODA su información en campos editables;
    /// el usuario cambia uno o varios atributos y guarda.
    /// </summary>
    [DesignerCategory("Form")]
    public partial class GUIActualizarLibroFisico : Form
    {
        private readonly LibroFisicoService servicio = new LibroFisicoService();
        private LibroFisico libroEncontrado;

        public GUIActualizarLibroFisico()
        {
            InitializeComponent();
            EstiloVentana.Aplicar(this, lblEncabezado);
            cboTipoTapa.Items.AddRange(TiposTapa.Opciones().ToArray());
            dtpFechaImpresion.MaxDate = DateTime.Today.AddDays(1).AddSeconds(-1); // no se permiten fechas futuras
            txtIsbnBuscar.TextChanged += txtIsbnBuscar_TextChanged;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Reiniciar();
            if (string.IsNullOrWhiteSpace(txtIsbnBuscar.Text))
            {
                errorProvider.SetError(txtIsbnBuscar, "Ingrese el ISBN del libro a actualizar.");
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (libroEncontrado == null || !Validar())
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show(this,
                "¿Desea guardar los cambios del libro con ISBN " + libroEncontrado.Isbn + "?",
                "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            var input = new LibroFisicoUpdateInput
            {
                Titulo = txtTitulo.Text.Trim(),
                Autor = txtAutor.Text.Trim(),
                Precio = (double)nudPrecio.Value,
                NumeroPaginas = (int)nudPaginas.Value,
                FechaImpresion = LibroFisicoService.FormatoFechaServidor(dtpFechaImpresion.Value),
                TipoTapa = ((TipoTapaOpcion)cboTipoTapa.SelectedItem).Valor
            };

            btnGuardar.Enabled = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                LibroFisico actualizado = await servicio.ActualizarAsync(libroEncontrado.Isbn, input);
                Mostrar(actualizado); // refleja el nuevo total a pagar calculado por el servidor
                Formato.Exito(this, "El libro físico se actualizó correctamente:\n\n" + Formato.Resumen(actualizado));
            }
            catch (ServicioException ex)
            {
                Formato.Error(this, ex.Message);
            }
            finally
            {
                btnGuardar.Enabled = libroEncontrado != null;
                Cursor = Cursors.Default;
            }
        }

        private void Mostrar(LibroFisico libro)
        {
            libroEncontrado = libro;
            txtIsbn.Text = libro.Isbn;
            txtTitulo.Text = libro.Titulo;
            txtAutor.Text = libro.Autor;
            nudPrecio.Value = Math.Min(nudPrecio.Maximum, (decimal)libro.Precio);
            nudPaginas.Value = Math.Max(nudPaginas.Minimum, Math.Min(nudPaginas.Maximum, libro.NumeroPaginas));
            dtpFechaImpresion.Value = libro.FechaImpresion > dtpFechaImpresion.MaxDate
                ? dtpFechaImpresion.MaxDate : libro.FechaImpresion;
            cboTipoTapa.SelectedItem = cboTipoTapa.Items.Cast<TipoTapaOpcion>()
                .FirstOrDefault(o => o.Valor == libro.TipoTapa);
            txtTotalPagar.Text = Formato.Moneda(libro.TotalPagar);

            grpDatos.Enabled = true;
            btnGuardar.Enabled = true;
            AcceptButton = btnGuardar;
            txtTitulo.Focus();
        }

        private bool Validar()
        {
            errorProvider.Clear();
            bool valido = true;
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                errorProvider.SetError(txtTitulo, "El título es obligatorio.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                errorProvider.SetError(txtAutor, "El autor es obligatorio.");
                valido = false;
            }
            if (nudPrecio.Value <= 0)
            {
                errorProvider.SetError(nudPrecio, "El precio debe ser mayor que cero.");
                valido = false;
            }
            if (!valido)
            {
                Formato.Aviso(this, "Revise los campos marcados en rojo.");
            }
            return valido;
        }

        /// <summary>Limpia los datos y deshabilita la edición hasta una nueva búsqueda.</summary>
        private void Reiniciar()
        {
            libroEncontrado = null;
            grpDatos.Enabled = false;
            btnGuardar.Enabled = false;
            AcceptButton = btnBuscar;
            txtIsbn.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtTotalPagar.Clear();
            nudPrecio.Value = 0;
            nudPaginas.Value = 100;
            dtpFechaImpresion.Value = DateTime.Now;
            cboTipoTapa.SelectedIndex = 0;
        }

        // Si el usuario cambia el ISBN después de buscar, se obliga a buscar de nuevo.
        private void txtIsbnBuscar_TextChanged(object sender, EventArgs e)
        {
            if (libroEncontrado != null)
            {
                Reiniciar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
