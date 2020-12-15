namespace VistaForm
{
    partial class FrmVistaAdministrador
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnCalcularGanancia = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(16, 160);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(286, 47);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Stock";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 34);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(286, 49);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Producto ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(16, 99);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(286, 49);
            this.btnEliminarProducto.TabIndex = 5;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnCalcularGanancia
            // 
            this.btnCalcularGanancia.Location = new System.Drawing.Point(16, 287);
            this.btnCalcularGanancia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcularGanancia.Name = "btnCalcularGanancia";
            this.btnCalcularGanancia.Size = new System.Drawing.Size(286, 49);
            this.btnCalcularGanancia.TabIndex = 6;
            this.btnCalcularGanancia.Text = "Ganancias del Local";
            this.btnCalcularGanancia.UseVisualStyleBackColor = true;
            this.btnCalcularGanancia.Click += new System.EventHandler(this.btnCalcularGanancia_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(16, 222);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(286, 48);
            this.btnPedidos.TabIndex = 7;
            this.btnPedidos.Text = "Pedidos confirmados";
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(176, 350);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(132, 23);
            this.btnCargarDatos.TabIndex = 8;
            this.btnCargarDatos.Text = "Cargar Datos Pruebas";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // FrmVistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(320, 385);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnCalcularGanancia);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnListar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVistaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modo vendedor";
            this.Load += new System.EventHandler(this.FrmVistaAdministrador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnCalcularGanancia;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnCargarDatos;
    }
}