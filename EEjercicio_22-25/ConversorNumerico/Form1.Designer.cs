namespace ConversorNumerico
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Curlz MT", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(52, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binario Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Curlz MT", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(61, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decimal binario";
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(609, 202);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(95, 72);
            this.btnBinToDec.TabIndex = 2;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(609, 345);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(95, 72);
            this.btnDecToBin.TabIndex = 3;
            this.btnDecToBin.Text = "->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(367, 202);
            this.txtBinario.Multiline = true;
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(227, 72);
            this.txtBinario.TabIndex = 4;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(367, 345);
            this.txtDecimal.Multiline = true;
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(227, 72);
            this.txtDecimal.TabIndex = 5;
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Enabled = false;
            this.txtResultadoDec.Location = new System.Drawing.Point(728, 202);
            this.txtResultadoDec.Multiline = true;
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(227, 72);
            this.txtResultadoDec.TabIndex = 6;
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Enabled = false;
            this.txtResultadoBin.Location = new System.Drawing.Point(728, 345);
            this.txtResultadoBin.Multiline = true;
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(227, 72);
            this.txtResultadoBin.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1115, 590);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Conversor numerico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.TextBox txtResultadoBin;
    }
}

