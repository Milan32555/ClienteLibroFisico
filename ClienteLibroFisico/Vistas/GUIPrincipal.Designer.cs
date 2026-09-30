namespace ClienteLibroFisico.Vistas
{
    partial class GUIPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLibroFisico = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsertar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.mnuListar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.escena = new ClienteLibroFisico.Vistas.EscenaLibreria();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            //
            // menuPrincipal
            //
            this.menuPrincipal.BackColor = System.Drawing.Color.White;
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuLibroFisico,
            this.mnuAyuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuPrincipal.Size = new System.Drawing.Size(1000, 31);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            //
            // mnuArchivo
            //
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(200, 22);
            this.mnuArchivo.Text = "&Archivo";
            //
            // mnuSalir
            //
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(200, 22);
            this.mnuSalir.Text = "&Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            //
            // mnuLibroFisico
            //
            this.mnuLibroFisico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInsertar,
            this.mnuConsultar,
            this.mnuActualizar,
            this.mnuEliminar,
            this.mnuSeparador,
            this.mnuListar});
            this.mnuLibroFisico.Name = "mnuLibroFisico";
            this.mnuLibroFisico.Size = new System.Drawing.Size(200, 22);
            this.mnuLibroFisico.Text = "&Libro físico";
            //
            // mnuInsertar
            //
            this.mnuInsertar.Name = "mnuInsertar";
            this.mnuInsertar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuInsertar.ShowShortcutKeys = false;
            this.mnuInsertar.Size = new System.Drawing.Size(200, 22);
            this.mnuInsertar.Text = "&Insertar...";
            this.mnuInsertar.Click += new System.EventHandler(this.mnuInsertar_Click);
            //
            // mnuConsultar
            //
            this.mnuConsultar.Name = "mnuConsultar";
            this.mnuConsultar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuConsultar.ShowShortcutKeys = false;
            this.mnuConsultar.Size = new System.Drawing.Size(200, 22);
            this.mnuConsultar.Text = "&Consultar...";
            this.mnuConsultar.Click += new System.EventHandler(this.mnuConsultar_Click);
            //
            // mnuActualizar
            //
            this.mnuActualizar.Name = "mnuActualizar";
            this.mnuActualizar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuActualizar.ShowShortcutKeys = false;
            this.mnuActualizar.Size = new System.Drawing.Size(200, 22);
            this.mnuActualizar.Text = "&Actualizar...";
            this.mnuActualizar.Click += new System.EventHandler(this.mnuActualizar_Click);
            //
            // mnuEliminar
            //
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEliminar.ShowShortcutKeys = false;
            this.mnuEliminar.Size = new System.Drawing.Size(200, 22);
            this.mnuEliminar.Text = "&Eliminar...";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            //
            // mnuSeparador
            //
            this.mnuSeparador.Name = "mnuSeparador";
            this.mnuSeparador.Size = new System.Drawing.Size(197, 6);
            //
            // mnuListar
            //
            this.mnuListar.Name = "mnuListar";
            this.mnuListar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuListar.ShowShortcutKeys = false;
            this.mnuListar.Size = new System.Drawing.Size(200, 22);
            this.mnuListar.Text = "&Listar...";
            this.mnuListar.Click += new System.EventHandler(this.mnuListar_Click);
            //
            // mnuAyuda
            //
            this.mnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAcercaDe});
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(200, 22);
            this.mnuAyuda.Text = "A&yuda";
            //
            // mnuAcercaDe
            //
            this.mnuAcercaDe.Name = "mnuAcercaDe";
            this.mnuAcercaDe.Size = new System.Drawing.Size(200, 22);
            this.mnuAcercaDe.Text = "&Acerca de...";
            this.mnuAcercaDe.Click += new System.EventHandler(this.mnuAcercaDe_Click);
            //
            // escena
            //
            this.escena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.escena.Location = new System.Drawing.Point(0, 31);
            this.escena.Name = "escena";
            this.escena.Size = new System.Drawing.Size(1000, 589);
            this.escena.TabIndex = 1;
            //
            // GUIPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.escena);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "GUIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librería - Gestión de Libros Físicos";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuLibroFisico;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertar;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultar;
        private System.Windows.Forms.ToolStripMenuItem mnuActualizar;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.ToolStripSeparator mnuSeparador;
        private System.Windows.Forms.ToolStripMenuItem mnuListar;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDe;
        private EscenaLibreria escena;
    }
}
