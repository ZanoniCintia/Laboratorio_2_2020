namespace FrmThreads
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
            this.lblDate = new System.Windows.Forms.Label();
            this.btnActiva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("MV Boli", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(93, 64);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(154, 39);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Aca se ve";
            // 
            // btnActiva
            // 
            this.btnActiva.BackColor = System.Drawing.Color.Fuchsia;
            this.btnActiva.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiva.ForeColor = System.Drawing.Color.Black;
            this.btnActiva.Location = new System.Drawing.Point(485, 31);
            this.btnActiva.Name = "btnActiva";
            this.btnActiva.Size = new System.Drawing.Size(281, 108);
            this.btnActiva.TabIndex = 2;
            this.btnActiva.Text = "Activa Hilo";
            this.btnActiva.UseVisualStyleBackColor = false;
            this.btnActiva.Click += new System.EventHandler(this.btnActiva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmThreads.Properties.Resources.hilospeq;
            this.ClientSize = new System.Drawing.Size(792, 695);
            this.Controls.Add(this.btnActiva);
            this.Controls.Add(this.lblDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnActiva;
    }
}

