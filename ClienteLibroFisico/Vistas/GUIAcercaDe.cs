using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>Muestra el nombre de los integrantes y la versión de la aplicación.</summary>
    [DesignerCategory("Form")]
    public partial class GUIAcercaDe : Form
    {
        public GUIAcercaDe()
        {
            InitializeComponent();
            EstiloVentana.EstilizarBoton(btnAceptar);
            // La versión se toma del ensamblado (Properties/AssemblyInfo.cs).
            Version v = typeof(GUIAcercaDe).Assembly.GetName().Version;
            lblVersion.Text = "Versión " + v.Major + "." + v.Minor + "." + v.Build;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelEncabezado_Paint(object sender, PaintEventArgs e)
        {
            EstiloVentana.PintarEncabezado(e.Graphics, panelEncabezado.ClientRectangle, "Acerca de", "Gestión de Libros Físicos");
        }
    }
}
