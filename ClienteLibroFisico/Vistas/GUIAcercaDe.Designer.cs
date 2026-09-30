namespace ClienteLibroFisico.Vistas
{
    partial class GUIAcercaDe
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
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblIntegrantesTitulo = new System.Windows.Forms.Label();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // panelEncabezado
            //
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(440, 78);
            this.panelEncabezado.TabIndex = 0;
            this.panelEncabezado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEncabezado_Paint);
            //
            // lblVersion
            //
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblVersion.Location = new System.Drawing.Point(21, 96);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Versión 1.0.0";
            //
            // lblCurso
            //
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblCurso.Location = new System.Drawing.Point(20, 120);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Diseño de Soluciones - Segundo Taller 2026B\r\nUniversidad de Ibagué - Facultad de Ingeniería";
            //
            // lblIntegrantesTitulo
            //
            this.lblIntegrantesTitulo.AutoSize = true;
            this.lblIntegrantesTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantesTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblIntegrantesTitulo.Location = new System.Drawing.Point(20, 182);
            this.lblIntegrantesTitulo.Name = "lblIntegrantesTitulo";
            this.lblIntegrantesTitulo.TabIndex = 3;
            this.lblIntegrantesTitulo.Text = "Integrantes del equipo";
            //
            // lblIntegrantes
            //
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblIntegrantes.Location = new System.Drawing.Point(20, 208);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.TabIndex = 4;
            this.lblIntegrantes.Text = "Sara Zambrano Ortiz\r\nAlejandra González Cortes\r\nMisael Gallo Tangarife\r\nSantiago Guimel Bahena";
            //
            // btnAceptar
            //
            this.btnAceptar.Location = new System.Drawing.Point(320, 314);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 32);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            //
            // GUIAcercaDe
            //
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnAceptar;
            this.ClientSize = new System.Drawing.Size(440, 366);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.lblIntegrantesTitulo);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUIAcercaDe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblIntegrantesTitulo;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Button btnAceptar;
    }
}
