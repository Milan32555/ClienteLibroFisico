using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using ClienteLibroFisico.Modelo;
using ClienteLibroFisico.Servicios;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>
    /// Caso de uso: Listar libros físicos.
    /// Muestra todos los registros en una grilla y permite filtrar por dos parámetros
    /// (autor y tipo de tapa). El filtrado lo hace el SERVIDOR.
    /// </summary>
    [DesignerCategory("Form")]
    public partial class GUIListarLibrosFisicos : Form
    {
        private readonly LibroFisicoService servicio = new LibroFisicoService();

        public GUIListarLibrosFisicos()
        {
            InitializeComponent();
            EstiloVentana.Aplicar(this, lblEncabezado);

            // Opciones del filtro de tapa: "Todos" + valores del enum
            var opciones = new List<TipoTapaOpcion> { new TipoTapaOpcion(null, "Todos") };
            opciones.AddRange(TiposTapa.Opciones());
            cboTipoTapaFiltro.Items.AddRange(opciones.ToArray());
            cboTipoTapaFiltro.SelectedIndex = 0;

            dgvLibros.AutoGenerateColumns = false;
            colPrecio.DefaultCellStyle.Format = "C2";
            colPrecio.DefaultCellStyle.FormatProvider = Formato.Colombia;
            colPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTotalPagar.DefaultCellStyle.Format = "C2";
            colTotalPagar.DefaultCellStyle.FormatProvider = Formato.Colombia;
            colTotalPagar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPaginas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colFechaImpresion.DefaultCellStyle.Format = Formato.FORMATO_FECHA;
            dgvLibros.CellFormatting += dgvLibros_CellFormatting;

            Load += GUIListarLibrosFisicos_Load;
        }

        private async void GUIListarLibrosFisicos_Load(object sender, EventArgs e)
        {
            await Cargar(false);
        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            await Cargar(true);
        }

        private async void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtAutorFiltro.Clear();
            cboTipoTapaFiltro.SelectedIndex = 0;
            await Cargar(false);
        }

        /// <summary>Consulta al servidor: todos los libros o solo los que cumplen los filtros.</summary>
        private async System.Threading.Tasks.Task Cargar(bool filtrar)
        {
            btnFiltrar.Enabled = false;
            btnMostrarTodos.Enabled = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                List<LibroFisico> libros;
                if (filtrar)
                {
                    string tipo = ((TipoTapaOpcion)cboTipoTapaFiltro.SelectedItem).Valor;
                    libros = await servicio.FiltrarAsync(txtAutorFiltro.Text, tipo);
                }
                else
                {
                    libros = await servicio.ListarAsync();
                }

                dgvLibros.DataSource = libros;
                lblTotal.Text = libros.Count + " libro(s) encontrado(s)";
                if (filtrar && libros.Count == 0)
                {
                    Formato.Aviso(this, "Ningún libro físico cumple con los filtros indicados.");
                }
            }
            catch (ServicioException ex)
            {
                dgvLibros.DataSource = null;
                lblTotal.Text = "0 libro(s) encontrado(s)";
                Formato.Error(this, ex.Message);
            }
            finally
            {
                btnFiltrar.Enabled = true;
                btnMostrarTodos.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        // Muestra "Tapa blanda"/"Tapa dura" en lugar de BLANDA/DURA
        private void dgvLibros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == colTipoTapa.Index && e.Value is string)
            {
                e.Value = TiposTapa.Nombre((string)e.Value);
                e.FormattingApplied = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
