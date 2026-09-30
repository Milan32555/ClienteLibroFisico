using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClienteLibroFisico.Modelo;
using ClienteLibroFisico.Servicios;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>Caso de uso: Insertar libro físico.</summary>
    [DesignerCategory("Form")]
    public partial class GUIInsertarLibroFisico : Form
    {
        private readonly LibroFisicoService servicio = new LibroFisicoService();

        public GUIInsertarLibroFisico()
        {
            InitializeComponent();
            EstiloVentana.Aplicar(this, lblEncabezado);
            cboTipoTapa.Items.AddRange(TiposTapa.Opciones().ToArray());
            dtpFechaImpresion.MaxDate = DateTime.Today.AddDays(1).AddSeconds(-1); // no se permiten fechas futuras
            Limpiar();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            var input = new LibroFisicoInput
            {
                Isbn = txtIsbn.Text.Trim(),
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
                LibroFisico creado = await servicio.CrearAsync(input);
                Formato.Exito(this, "El libro físico se registró correctamente:\n\n" + Formato.Resumen(creado));
                Limpiar();
            }
            catch (ServicioException ex)
            {
                Formato.Error(this, ex.Message);
            }
            finally
            {
                btnGuardar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private bool Validar()
        {
            errorProvider.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtIsbn.Text))
            {
                errorProvider.SetError(txtIsbn, "El ISBN es obligatorio.");
                valido = false;
            }
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
            if (cboTipoTapa.SelectedItem == null)
            {
                errorProvider.SetError(cboTipoTapa, "Seleccione el tipo de tapa.");
                valido = false;
            }

            if (!valido)
            {
                Formato.Aviso(this, "Revise los campos marcados en rojo.");
            }
            return valido;
        }

        private void Limpiar()
        {
            errorProvider.Clear();
            txtIsbn.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            nudPrecio.Value = 0;
            nudPaginas.Value = 100;
            dtpFechaImpresion.Value = DateTime.Now;
            cboTipoTapa.SelectedIndex = 0;
            txtIsbn.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
