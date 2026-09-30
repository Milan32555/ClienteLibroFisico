namespace ClienteLibroFisico.Vistas
{
    partial class GUIActualizarLibroFisico
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
            this.components = new System.ComponentModel.Container();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.lblIsbnBuscar = new System.Windows.Forms.Label();
            this.txtIsbnBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.nudPaginas = new System.Windows.Forms.NumericUpDown();
            this.lblFechaImpresion = new System.Windows.Forms.Label();
            this.dtpFechaImpresion = new System.Windows.Forms.DateTimePicker();
            this.lblTipoTapa = new System.Windows.Forms.Label();
            this.cboTipoTapa = new System.Windows.Forms.ComboBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBusqueda.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(20, 15);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "Actualizar un libro físico";
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.lblIsbnBuscar);
            this.grpBusqueda.Controls.Add(this.txtIsbnBuscar);
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            this.grpBusqueda.Location = new System.Drawing.Point(20, 50);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(500, 70);
            this.grpBusqueda.TabIndex = 1;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Buscar libro físico";
            // 
            // lblIsbnBuscar
            // 
            this.lblIsbnBuscar.AutoSize = true;
            this.lblIsbnBuscar.Location = new System.Drawing.Point(20, 32);
            this.lblIsbnBuscar.Name = "lblIsbnBuscar";
            this.lblIsbnBuscar.TabIndex = 0;
            this.lblIsbnBuscar.Text = "ISBN:";
            // 
            // txtIsbnBuscar
            // 
            this.txtIsbnBuscar.Location = new System.Drawing.Point(70, 29);
            this.txtIsbnBuscar.MaxLength = 20;
            this.txtIsbnBuscar.Name = "txtIsbnBuscar";
            this.txtIsbnBuscar.Size = new System.Drawing.Size(290, 23);
            this.txtIsbnBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(375, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblIsbn);
            this.grpDatos.Controls.Add(this.txtIsbn);
            this.grpDatos.Controls.Add(this.lblTitulo);
            this.grpDatos.Controls.Add(this.txtTitulo);
            this.grpDatos.Controls.Add(this.lblAutor);
            this.grpDatos.Controls.Add(this.txtAutor);
            this.grpDatos.Controls.Add(this.lblPrecio);
            this.grpDatos.Controls.Add(this.nudPrecio);
            this.grpDatos.Controls.Add(this.lblPaginas);
            this.grpDatos.Controls.Add(this.nudPaginas);
            this.grpDatos.Controls.Add(this.lblFechaImpresion);
            this.grpDatos.Controls.Add(this.dtpFechaImpresion);
            this.grpDatos.Controls.Add(this.lblTipoTapa);
            this.grpDatos.Controls.Add(this.cboTipoTapa);
            this.grpDatos.Controls.Add(this.lblTotalPagar);
            this.grpDatos.Controls.Add(this.txtTotalPagar);
            this.grpDatos.Enabled = false;
            this.grpDatos.Location = new System.Drawing.Point(20, 130);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(500, 310);
            this.grpDatos.TabIndex = 2;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del libro (edite los campos que desee cambiar)";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(20, 33);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.TabIndex = 0;
            this.lblIsbn.Text = "ISBN:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(180, 30);
            this.txtIsbn.MaxLength = 20;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.ReadOnly = true;
            this.txtIsbn.BackColor = System.Drawing.SystemColors.Window;
            this.txtIsbn.Size = new System.Drawing.Size(280, 23);
            this.txtIsbn.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 67);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(180, 64);
            this.txtTitulo.MaxLength = 150;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(280, 23);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(20, 101);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(180, 98);
            this.txtAutor.MaxLength = 100;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(280, 23);
            this.txtAutor.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 135);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio (COP):";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Increment = new decimal(new int[] { 1000, 0, 0, 0});
            this.nudPrecio.Location = new System.Drawing.Point(180, 132);
            this.nudPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0});
            this.nudPrecio.Minimum = new decimal(new int[] { 0, 0, 0, 0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(180, 23);
            this.nudPrecio.TabIndex = 7;
            this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrecio.ThousandsSeparator = true;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(20, 169);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.TabIndex = 8;
            this.lblPaginas.Text = "Número de páginas:";
            // 
            // nudPaginas
            // 
            this.nudPaginas.Increment = new decimal(new int[] { 1, 0, 0, 0});
            this.nudPaginas.Location = new System.Drawing.Point(180, 166);
            this.nudPaginas.Maximum = new decimal(new int[] { 10000, 0, 0, 0});
            this.nudPaginas.Minimum = new decimal(new int[] { 1, 0, 0, 0});
            this.nudPaginas.Name = "nudPaginas";
            this.nudPaginas.Size = new System.Drawing.Size(130, 23);
            this.nudPaginas.TabIndex = 9;
            this.nudPaginas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPaginas.ThousandsSeparator = true;
            this.nudPaginas.Value = new decimal(new int[] { 100, 0, 0, 0});
            // 
            // lblFechaImpresion
            // 
            this.lblFechaImpresion.AutoSize = true;
            this.lblFechaImpresion.Location = new System.Drawing.Point(20, 203);
            this.lblFechaImpresion.Name = "lblFechaImpresion";
            this.lblFechaImpresion.TabIndex = 10;
            this.lblFechaImpresion.Text = "Fecha de impresión:";
            // 
            // dtpFechaImpresion
            // 
            this.dtpFechaImpresion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaImpresion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaImpresion.Location = new System.Drawing.Point(180, 200);
            this.dtpFechaImpresion.Name = "dtpFechaImpresion";
            this.dtpFechaImpresion.ShowUpDown = false;
            this.dtpFechaImpresion.Size = new System.Drawing.Size(180, 23);
            this.dtpFechaImpresion.TabIndex = 11;
            // 
            // lblTipoTapa
            // 
            this.lblTipoTapa.AutoSize = true;
            this.lblTipoTapa.Location = new System.Drawing.Point(20, 237);
            this.lblTipoTapa.Name = "lblTipoTapa";
            this.lblTipoTapa.TabIndex = 12;
            this.lblTipoTapa.Text = "Tipo de tapa:";
            // 
            // cboTipoTapa
            // 
            this.cboTipoTapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTapa.FormattingEnabled = true;
            this.cboTipoTapa.Location = new System.Drawing.Point(180, 234);
            this.cboTipoTapa.Name = "cboTipoTapa";
            this.cboTipoTapa.Size = new System.Drawing.Size(180, 23);
            this.cboTipoTapa.TabIndex = 13;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(20, 271);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.TabIndex = 14;
            this.lblTotalPagar.Text = "Total a pagar actual:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(180, 268);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPagar.Size = new System.Drawing.Size(280, 23);
            this.txtTotalPagar.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(170, 450);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(310, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(420, 450);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // GUIActualizarLibroFisico
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(540, 490);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.lblEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUIActualizarLibroFisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar libro físico";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label lblIsbnBuscar;
        private System.Windows.Forms.TextBox txtIsbnBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.NumericUpDown nudPaginas;
        private System.Windows.Forms.Label lblFechaImpresion;
        private System.Windows.Forms.DateTimePicker dtpFechaImpresion;
        private System.Windows.Forms.Label lblTipoTapa;
        private System.Windows.Forms.ComboBox cboTipoTapa;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
