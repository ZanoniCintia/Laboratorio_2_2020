namespace FormBaja
{
    partial class FrmBaja
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
            this.lblHeaderBaja = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.rTBDatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblHeaderBaja
            // 
            this.lblHeaderBaja.AutoSize = true;
            this.lblHeaderBaja.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderBaja.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderBaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeaderBaja.Location = new System.Drawing.Point(41, 39);
            this.lblHeaderBaja.Name = "lblHeaderBaja";
            this.lblHeaderBaja.Size = new System.Drawing.Size(412, 30);
            this.lblHeaderBaja.TabIndex = 0;
            this.lblHeaderBaja.Text = "Ingrese el legajo a ser dado de baja";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.BackColor = System.Drawing.Color.Transparent;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLegajo.Location = new System.Drawing.Point(28, 101);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(114, 36);
            this.lblLegajo.TabIndex = 1;
            this.lblLegajo.Text = "Legajo:";
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(0, 340);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(164, 66);
            this.btnDatos.TabIndex = 2;
            this.btnDatos.Text = "Ver Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(330, 340);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(164, 66);
            this.btnCancela.TabIndex = 4;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // txtLegajo
            // 
            this.txtLegajo.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtLegajo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLegajo.Location = new System.Drawing.Point(210, 116);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(233, 20);
            this.txtLegajo.TabIndex = 1;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(165, 340);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(164, 66);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // rTBDatos
            // 
            this.rTBDatos.BackColor = System.Drawing.SystemColors.WindowText;
            this.rTBDatos.ForeColor = System.Drawing.SystemColors.Window;
            this.rTBDatos.Location = new System.Drawing.Point(18, 181);
            this.rTBDatos.Name = "rTBDatos";
            this.rTBDatos.Size = new System.Drawing.Size(465, 141);
            this.rTBDatos.TabIndex = 5;
            this.rTBDatos.Text = "";
            // 
            // FrmBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormBaja.Properties.Resources.Untitled_12;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.rTBDatos);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblHeaderBaja);
            this.Name = "FrmBaja";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.FrmBaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderBaja;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.RichTextBox rTBDatos;
    }
}


