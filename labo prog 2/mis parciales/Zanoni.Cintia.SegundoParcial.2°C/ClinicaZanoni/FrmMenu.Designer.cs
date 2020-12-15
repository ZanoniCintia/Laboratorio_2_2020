namespace ClinicaZanoni
{
    partial class FrmMenu
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
            this.lblEspecialistas = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.GrBoxClinica = new System.Windows.Forms.GroupBox();
            this.dataGridPacientes = new System.Windows.Forms.DataGridView();
            this.dataGridEspecialistas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.GrBoxClinica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecialistas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspecialistas
            // 
            this.lblEspecialistas.AutoSize = true;
            this.lblEspecialistas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEspecialistas.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialistas.Location = new System.Drawing.Point(-5, 48);
            this.lblEspecialistas.Name = "lblEspecialistas";
            this.lblEspecialistas.Size = new System.Drawing.Size(234, 30);
            this.lblEspecialistas.TabIndex = 0;
            this.lblEspecialistas.Text = "Lista de Especialistas";
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.BackColor = System.Drawing.Color.White;
            this.lblPacientes.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.Location = new System.Drawing.Point(543, 48);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(200, 30);
            this.lblPacientes.TabIndex = 2;
            this.lblPacientes.Text = "Lista de pacientes";
            // 
            // GrBoxClinica
            // 
            this.GrBoxClinica.BackColor = System.Drawing.Color.Transparent;
            this.GrBoxClinica.Controls.Add(this.dataGridPacientes);
            this.GrBoxClinica.Controls.Add(this.btnSalir);
            this.GrBoxClinica.Controls.Add(this.dataGridEspecialistas);
            this.GrBoxClinica.Controls.Add(this.lblPacientes);
            this.GrBoxClinica.Controls.Add(this.lblEspecialistas);
            this.GrBoxClinica.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBoxClinica.Location = new System.Drawing.Point(17, 12);
            this.GrBoxClinica.Name = "GrBoxClinica";
            this.GrBoxClinica.Size = new System.Drawing.Size(1074, 822);
            this.GrBoxClinica.TabIndex = 5;
            this.GrBoxClinica.TabStop = false;
            this.GrBoxClinica.Text = "Clinica ZANONI";
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(524, 81);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.RowHeadersVisible = false;
            this.dataGridPacientes.RowHeadersWidth = 82;
            this.dataGridPacientes.RowTemplate.Height = 33;
            this.dataGridPacientes.Size = new System.Drawing.Size(515, 566);
            this.dataGridPacientes.TabIndex = 11;
            // 
            // dataGridEspecialistas
            // 
            this.dataGridEspecialistas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEspecialistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEspecialistas.Location = new System.Drawing.Point(6, 81);
            this.dataGridEspecialistas.Name = "dataGridEspecialistas";
            this.dataGridEspecialistas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridEspecialistas.RowHeadersVisible = false;
            this.dataGridEspecialistas.RowHeadersWidth = 82;
            this.dataGridEspecialistas.RowTemplate.Height = 33;
            this.dataGridEspecialistas.Size = new System.Drawing.Size(512, 566);
            this.dataGridEspecialistas.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(796, 653);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(243, 63);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaZanoni.Properties.Resources.clinicap;
            this.ClientSize = new System.Drawing.Size(1117, 915);
            this.ControlBox = false;
            this.Controls.Add(this.GrBoxClinica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.GrBoxClinica.ResumeLayout(false);
            this.GrBoxClinica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecialistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEspecialistas;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.GroupBox GrBoxClinica;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridPacientes;
        private System.Windows.Forms.DataGridView dataGridEspecialistas;
    }
}

