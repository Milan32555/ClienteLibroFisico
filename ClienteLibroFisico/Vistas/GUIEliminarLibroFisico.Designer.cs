namespace ClienteLibroFisico.Vistas
{
    partial class GUIEliminarLibroFisico
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
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblFechaImpresion = new System.Windows.Forms.Label();
            this.txtFechaImpresion = new System.Windows.Forms.TextBox();
            this.lblTipoTapa = new System.Windows.Forms.Label();
            this.txtTipoTapa = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBusqueda.SuspendLayout();
            this.grpResultado.SuspendLayout();
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
            this.lblEncabezado.Text = "Eliminar un libro físico";
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
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.lblIsbn);
            this.grpResultado.Controls.Add(this.txtIsbn);
            this.grpResultado.Controls.Add(this.lblTitulo);
            this.grpResultado.Controls.Add(this.txtTitulo);
            this.grpResultado.Controls.Add(this.lblAutor);
            this.grpResultado.Controls.Add(this.txtAutor);
            this.grpResultado.Controls.Add(this.lblPrecio);
            this.grpResultado.Controls.Add(this.txtPrecio);
            this.grpResultado.Controls.Add(this.lblPaginas);
            this.grpResultado.Controls.Add(this.txtPaginas);
            this.grpResultado.Controls.Add(this.lblFechaImpresion);
            this.grpResultado.Controls.Add(this.txtFechaImpresion);
            this.grpResultado.Controls.Add(this.lblTipoTapa);
            this.grpResultado.Controls.Add(this.txtTipoTapa);
            this.grpResultado.Controls.Add(this.lblTotalPagar);
            this.grpResultado.Controls.Add(this.txtTotalPagar);
            this.grpResultado.Location = new System.Drawing.Point(20, 130);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(500, 305);
            this.grpResultado.TabIndex = 2;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Información del libro a eliminar";
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
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Window;
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
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutor.Size = new System.Drawing.Size(280, 23);
            this.txtAutor.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 135);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(180, 132);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.Size = new System.Drawing.Size(280, 23);
            this.txtPrecio.TabIndex = 7;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(20, 169);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.TabIndex = 8;
            this.lblPaginas.Text = "Número de páginas:";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(180, 166);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.ReadOnly = true;
            this.txtPaginas.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaginas.Size = new System.Drawing.Size(280, 23);
            this.txtPaginas.TabIndex = 9;
            // 
            // lblFechaImpresion
            // 
            this.lblFechaImpresion.AutoSize = true;
            this.lblFechaImpresion.Location = new System.Drawing.Point(20, 203);
            this.lblFechaImpresion.Name = "lblFechaImpresion";
            this.lblFechaImpresion.TabIndex = 10;
            this.lblFechaImpresion.Text = "Fecha de impresión:";
            // 
            // txtFechaImpresion
            // 
            this.txtFechaImpresion.Location = new System.Drawing.Point(180, 200);
            this.txtFechaImpresion.Name = "txtFechaImpresion";
            this.txtFechaImpresion.ReadOnly = true;
            this.txtFechaImpresion.BackColor = System.Drawing.SystemColors.Window;
            this.txtFechaImpresion.Size = new System.Drawing.Size(280, 23);
            this.txtFechaImpresion.TabIndex = 11;
            // 
            // lblTipoTapa
            // 
            this.lblTipoTapa.AutoSize = true;
            this.lblTipoTapa.Location = new System.Drawing.Point(20, 237);
            this.lblTipoTapa.Name = "lblTipoTapa";
            this.lblTipoTapa.TabIndex = 12;
            this.lblTipoTapa.Text = "Tipo de tapa:";
            // 
            // txtTipoTapa
            // 
            this.txtTipoTapa.Location = new System.Drawing.Point(180, 234);
            this.txtTipoTapa.Name = "txtTipoTapa";
            this.txtTipoTapa.ReadOnly = true;
            this.txtTipoTapa.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoTapa.Size = new System.Drawing.Size(280, 23);
            this.txtTipoTapa.TabIndex = 13;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(20, 271);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.TabIndex = 14;
            this.lblTotalPagar.Text = "Total a pagar:";
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
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(200, 445);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(310, 445);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(420, 445);
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
            // GUIEliminarLibroFisico
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(540, 485);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.lblEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUIEliminarLibroFisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar libro físico";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label lblIsbnBuscar;
        private System.Windows.Forms.TextBox txtIsbnBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label lblFechaImpresion;
        private System.Windows.Forms.TextBox txtFechaImpresion;
        private System.Windows.Forms.Label lblTipoTapa;
        private System.Windows.Forms.TextBox txtTipoTapa;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
