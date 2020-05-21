namespace VistaForm
{
    partial class FrmListar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvMostar = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMostar
            // 
            this.dtgvMostar.AllowUserToAddRows = false;
            this.dtgvMostar.AllowUserToDeleteRows = false;
            this.dtgvMostar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMostar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clTipoProducto,
            this.clMarca,
            this.clPrecio,
            this.clStock,
            this.clColor});
            this.dtgvMostar.Location = new System.Drawing.Point(22, 21);
            this.dtgvMostar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvMostar.Name = "dtgvMostar";
            this.dtgvMostar.ReadOnly = true;
            this.dtgvMostar.RowHeadersWidth = 82;
            this.dtgvMostar.RowTemplate.Height = 33;
            this.dtgvMostar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMostar.Size = new System.Drawing.Size(1360, 717);
            this.dtgvMostar.TabIndex = 0;
            this.dtgvMostar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMostar_CellDoubleClick);
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Codigo";
            this.clCodigo.MinimumWidth = 10;
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.ReadOnly = true;
            this.clCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clCodigo.Width = 200;
            // 
            // clTipoProducto
            // 
            this.clTipoProducto.HeaderText = "Producto";
            this.clTipoProducto.MinimumWidth = 10;
            this.clTipoProducto.Name = "clTipoProducto";
            this.clTipoProducto.ReadOnly = true;
            this.clTipoProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clTipoProducto.Width = 200;
            // 
            // clMarca
            // 
            this.clMarca.HeaderText = "Marca";
            this.clMarca.MinimumWidth = 10;
            this.clMarca.Name = "clMarca";
            this.clMarca.ReadOnly = true;
            this.clMarca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clMarca.Width = 200;
            // 
            // clPrecio
            // 
            this.clPrecio.HeaderText = "Precio";
            this.clPrecio.MinimumWidth = 10;
            this.clPrecio.Name = "clPrecio";
            this.clPrecio.ReadOnly = true;
            this.clPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clPrecio.Width = 200;
            // 
            // clStock
            // 
            this.clStock.HeaderText = "Stock";
            this.clStock.MinimumWidth = 10;
            this.clStock.Name = "clStock";
            this.clStock.ReadOnly = true;
            this.clStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clStock.Width = 200;
            // 
            // clColor
            // 
            this.clColor.HeaderText = "Color";
            this.clColor.MinimumWidth = 10;
            this.clColor.Name = "clColor";
            this.clColor.ReadOnly = true;
            this.clColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clColor.Width = 200;
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VistaForm.Properties.Resources.Herramientas;
            this.ClientSize = new System.Drawing.Size(1415, 767);
            this.Controls.Add(this.dtgvMostar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Stock";
            this.Load += new System.EventHandler(this.FrmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMostar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clColor;
    }
}