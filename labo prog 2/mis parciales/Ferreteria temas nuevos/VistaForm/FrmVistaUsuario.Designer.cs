namespace VistaForm
{
    partial class FrmVistaUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaUsuario));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCarrito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAmbito = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.listBoxStock = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnInstruccionUso = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CarritoCompras.jpeg");
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackColor = System.Drawing.Color.Black;
            this.btnCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.ForeColor = System.Drawing.Color.White;
            this.btnCarrito.Image = ((System.Drawing.Image)(resources.GetObject("btnCarrito.Image")));
            this.btnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrito.Location = new System.Drawing.Point(972, 33);
            this.btnCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(302, 87);
            this.btnCarrito.TabIndex = 0;
            this.btnCarrito.Text = "Ver Carrito";
            this.btnCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ambito";
            // 
            // cmbAmbito
            // 
            this.cmbAmbito.FormattingEnabled = true;
            this.cmbAmbito.Location = new System.Drawing.Point(304, 154);
            this.cmbAmbito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAmbito.Name = "cmbAmbito";
            this.cmbAmbito.Size = new System.Drawing.Size(200, 33);
            this.cmbAmbito.TabIndex = 2;
            this.cmbAmbito.SelectedIndexChanged += new System.EventHandler(this.cmbAmbito_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1082, 610);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(192, 81);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(56, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Iluminaria",
            "Herramientas",
            "Insumos"});
            this.cmbCategoria.Location = new System.Drawing.Point(60, 154);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(200, 33);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(52, 67);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(119, 25);
            this.lblSaludo.TabIndex = 6;
            this.lblSaludo.Text = "Bienvenido";
            // 
            // listBoxStock
            // 
            this.listBoxStock.FormattingEnabled = true;
            this.listBoxStock.ItemHeight = 25;
            this.listBoxStock.Location = new System.Drawing.Point(60, 223);
            this.listBoxStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxStock.Name = "listBoxStock";
            this.listBoxStock.Size = new System.Drawing.Size(996, 479);
            this.listBoxStock.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(1082, 390);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(192, 71);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnInstruccionUso
            // 
            this.btnInstruccionUso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInstruccionUso.Location = new System.Drawing.Point(1082, 494);
            this.btnInstruccionUso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstruccionUso.Name = "btnInstruccionUso";
            this.btnInstruccionUso.Size = new System.Drawing.Size(192, 71);
            this.btnInstruccionUso.TabIndex = 9;
            this.btnInstruccionUso.Text = "Instrucciones de uso";
            this.btnInstruccionUso.UseVisualStyleBackColor = false;
            this.btnInstruccionUso.Click += new System.EventHandler(this.btnInstruccionUso_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.Color.Magenta;
            this.btnMostrarTodos.Location = new System.Drawing.Point(1082, 158);
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(192, 81);
            this.btnMostrarTodos.TabIndex = 11;
            this.btnMostrarTodos.Text = "Mostrar Lista Completa";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // FrmVistaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1347, 833);
            this.ControlBox = false;
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnInstruccionUso);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listBoxStock);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbAmbito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVistaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmVistaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAmbito;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.ListBox listBoxStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnInstruccionUso;
        private System.Windows.Forms.Button btnMostrarTodos;
    }
}