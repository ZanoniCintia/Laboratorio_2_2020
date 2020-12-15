namespace VistaForm
{
    partial class FrmCarrito
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
            this.listBoxCarrito = new System.Windows.Forms.ListBox();
            this.btnEliminarCarrito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxTotal = new System.Windows.Forms.RichTextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCarrito
            // 
            this.listBoxCarrito.FormattingEnabled = true;
            this.listBoxCarrito.ItemHeight = 25;
            this.listBoxCarrito.Location = new System.Drawing.Point(28, 29);
            this.listBoxCarrito.Name = "listBoxCarrito";
            this.listBoxCarrito.Size = new System.Drawing.Size(513, 654);
            this.listBoxCarrito.TabIndex = 0;
            // 
            // btnEliminarCarrito
            // 
            this.btnEliminarCarrito.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCarrito.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarCarrito.Location = new System.Drawing.Point(575, 119);
            this.btnEliminarCarrito.Name = "btnEliminarCarrito";
            this.btnEliminarCarrito.Size = new System.Drawing.Size(188, 81);
            this.btnEliminarCarrito.TabIndex = 1;
            this.btnEliminarCarrito.Text = "Eliminar del carrito";
            this.btnEliminarCarrito.UseVisualStyleBackColor = false;
            this.btnEliminarCarrito.Click += new System.EventHandler(this.btnEliminarCarrito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(580, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total :";
            // 
            // richTextBoxTotal
            // 
            this.richTextBoxTotal.Location = new System.Drawing.Point(575, 330);
            this.richTextBoxTotal.Name = "richTextBoxTotal";
            this.richTextBoxTotal.Size = new System.Drawing.Size(188, 51);
            this.richTextBoxTotal.TabIndex = 3;
            this.richTextBoxTotal.Text = "";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnComprar.ForeColor = System.Drawing.Color.Black;
            this.btnComprar.Location = new System.Drawing.Point(575, 408);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(188, 61);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(575, 575);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(188, 63);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 779);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.richTextBoxTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarCarrito);
            this.Controls.Add(this.listBoxCarrito);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCarrito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCarrito;
        private System.Windows.Forms.Button btnEliminarCarrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxTotal;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnVolver;
    }
}