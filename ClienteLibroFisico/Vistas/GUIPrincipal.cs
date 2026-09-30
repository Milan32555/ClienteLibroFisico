using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ClienteLibroFisico.Vistas
{
    /// <summary>Ventana principal: solo contiene el menú que lleva a cada caso de uso.</summary>
    [DesignerCategory("Form")]
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
            EstiloMenu.Aplicar(menuPrincipal);
            Shown += (s, e) => escena.Animar();
        }

        private void Abrir(Form ventana)
        {
            using (ventana)
            {
                ventana.ShowDialog(this);
            }
        }

        private void mnuInsertar_Click(object sender, EventArgs e)
        {
            Abrir(new GUIInsertarLibroFisico());
        }

        private void mnuConsultar_Click(object sender, EventArgs e)
        {
            Abrir(new GUIConsultarLibroFisico());
        }

        private void mnuActualizar_Click(object sender, EventArgs e)
        {
            Abrir(new GUIActualizarLibroFisico());
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            Abrir(new GUIEliminarLibroFisico());
        }

        private void mnuListar_Click(object sender, EventArgs e)
        {
            Abrir(new GUIListarLibrosFisicos());
        }

        private void mnuAcercaDe_Click(object sender, EventArgs e)
        {
            Abrir(new GUIAcercaDe());
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
