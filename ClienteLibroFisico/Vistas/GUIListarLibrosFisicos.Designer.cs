namespace ClienteLibroFisico.Vistas
{
    partial class GUIListarLibrosFisicos
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
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblAutorFiltro = new System.Windows.Forms.Label();
            this.txtAutorFiltro = new System.Windows.Forms.TextBox();
            this.lblTipoTapaFiltro = new System.Windows.Forms.Label();
            this.cboTipoTapaFiltro = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.colIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaImpresion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoTapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(20, 15);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "Listado de libros físicos";
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblAutorFiltro);
            this.grpFiltros.Controls.Add(this.txtAutorFiltro);
            this.grpFiltros.Controls.Add(this.lblTipoTapaFiltro);
            this.grpFiltros.Controls.Add(this.cboTipoTapaFiltro);
            this.grpFiltros.Controls.Add(this.btnFiltrar);
            this.grpFiltros.Controls.Add(this.btnMostrarTodos);
            this.grpFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltros.Location = new System.Drawing.Point(20, 50);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(860, 70);
            this.grpFiltros.TabIndex = 1;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros (se aplican en el servidor)";
            // 
            // lblAutorFiltro
            // 
            this.lblAutorFiltro.AutoSize = true;
            this.lblAutorFiltro.Location = new System.Drawing.Point(15, 32);
            this.lblAutorFiltro.Name = "lblAutorFiltro";
            this.lblAutorFiltro.TabIndex = 0;
            this.lblAutorFiltro.Text = "Autor:";
            // 
            // txtAutorFiltro
            // 
            this.txtAutorFiltro.Location = new System.Drawing.Point(65, 29);
            this.txtAutorFiltro.MaxLength = 100;
            this.txtAutorFiltro.Name = "txtAutorFiltro";
            this.txtAutorFiltro.Size = new System.Drawing.Size(240, 23);
            this.txtAutorFiltro.TabIndex = 1;
            // 
            // lblTipoTapaFiltro
            // 
            this.lblTipoTapaFiltro.AutoSize = true;
            this.lblTipoTapaFiltro.Location = new System.Drawing.Point(325, 32);
            this.lblTipoTapaFiltro.Name = "lblTipoTapaFiltro";
            this.lblTipoTapaFiltro.TabIndex = 2;
            this.lblTipoTapaFiltro.Text = "Tipo de tapa:";
            // 
            // cboTipoTapaFiltro
            // 
            this.cboTipoTapaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTapaFiltro.FormattingEnabled = true;
            this.cboTipoTapaFiltro.Location = new System.Drawing.Point(410, 29);
            this.cboTipoTapaFiltro.Name = "cboTipoTapaFiltro";
            this.cboTipoTapaFiltro.Size = new System.Drawing.Size(140, 23);
            this.cboTipoTapaFiltro.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(570, 25);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(120, 30);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(700, 25);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(140, 30);
            this.btnMostrarTodos.TabIndex = 5;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIsbn,
            this.colTitulo,
            this.colAutor,
            this.colPrecio,
            this.colPaginas,
            this.colFechaImpresion,
            this.colTipoTapa,
            this.colTotalPagar});
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AllowUserToResizeRows = false;
            this.dgvLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(20, 130);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(860, 335);
            this.dgvLibros.TabIndex = 2;
            // 
            // colIsbn
            // 
            this.colIsbn.DataPropertyName = "Isbn";
            this.colIsbn.FillWeight = 90F;
            this.colIsbn.HeaderText = "ISBN";
            this.colIsbn.Name = "colIsbn";
            this.colIsbn.ReadOnly = true;
            // 
            // colTitulo
            // 
            this.colTitulo.DataPropertyName = "Titulo";
            this.colTitulo.FillWeight = 160F;
            this.colTitulo.HeaderText = "Título";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.DataPropertyName = "Autor";
            this.colAutor.FillWeight = 140F;
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "Precio";
            this.colPrecio.FillWeight = 90F;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colPaginas
            // 
            this.colPaginas.DataPropertyName = "NumeroPaginas";
            this.colPaginas.FillWeight = 60F;
            this.colPaginas.HeaderText = "Páginas";
            this.colPaginas.Name = "colPaginas";
            this.colPaginas.ReadOnly = true;
            // 
            // colFechaImpresion
            // 
            this.colFechaImpresion.DataPropertyName = "FechaImpresion";
            this.colFechaImpresion.FillWeight = 110F;
            this.colFechaImpresion.HeaderText = "Fecha de impresión";
            this.colFechaImpresion.Name = "colFechaImpresion";
            this.colFechaImpresion.ReadOnly = true;
            // 
            // colTipoTapa
            // 
            this.colTipoTapa.DataPropertyName = "TipoTapa";
            this.colTipoTapa.FillWeight = 80F;
            this.colTipoTapa.HeaderText = "Tipo de tapa";
            this.colTipoTapa.Name = "colTipoTapa";
            this.colTipoTapa.ReadOnly = true;
            // 
            // colTotalPagar
            // 
            this.colTotalPagar.DataPropertyName = "TotalPagar";
            this.colTotalPagar.FillWeight = 100F;
            this.colTotalPagar.HeaderText = "Total a pagar";
            this.colTotalPagar.Name = "colTotalPagar";
            this.colTotalPagar.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 481);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0 libro(s) encontrado(s)";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(780, 475);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // GUIListarLibrosFisicos
            // 
            this.AcceptButton = this.btnFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.lblEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(760, 400);
            this.Name = "GUIListarLibrosFisicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listar libros físicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblAutorFiltro;
        private System.Windows.Forms.TextBox txtAutorFiltro;
        private System.Windows.Forms.Label lblTipoTapaFiltro;
        private System.Windows.Forms.ComboBox cboTipoTapaFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaImpresion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoTapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPagar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCerrar;
    }
}
