namespace FormBase
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsulta.Location = new System.Drawing.Point(38, 42);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(217, 63);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlta.Location = new System.Drawing.Point(38, 124);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(217, 63);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Altas";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModif
            // 
            this.btnModif.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btnModif.Location = new System.Drawing.Point(38, 207);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(217, 63);
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modificaciones";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.btnBaja.Location = new System.Drawing.Point(38, 289);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(217, 63);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Bajas";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormBase.Properties.Resources.Untitled_1;
            this.ClientSize = new System.Drawing.Size(570, 409);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos UTN";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnBaja;
    }
}

