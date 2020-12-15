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
            this.btnAsignarTurnoClinica = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAsigTurnoDerivado = new System.Windows.Forms.Button();
            this.GrBoxClinica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecialistas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspecialistas
            // 
            this.lblEspecialistas.AutoSize = true;
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
            this.lblPacientes.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.Location = new System.Drawing.Point(6, 328);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(200, 30);
            this.lblPacientes.TabIndex = 2;
            this.lblPacientes.Text = "Lista de pacientes";
            // 
            // GrBoxClinica
            // 
            this.GrBoxClinica.BackColor = System.Drawing.Color.Transparent;
            this.GrBoxClinica.Controls.Add(this.btnAsigTurnoDerivado);
            this.GrBoxClinica.Controls.Add(this.dataGridPacientes);
            this.GrBoxClinica.Controls.Add(this.dataGridEspecialistas);
            this.GrBoxClinica.Controls.Add(this.btnAsignarTurnoClinica);
            this.GrBoxClinica.Controls.Add(this.btnSalir);
            this.GrBoxClinica.Controls.Add(this.lblPacientes);
            this.GrBoxClinica.Controls.Add(this.lblEspecialistas);
            this.GrBoxClinica.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBoxClinica.Location = new System.Drawing.Point(17, 12);
            this.GrBoxClinica.Name = "GrBoxClinica";
            this.GrBoxClinica.Size = new System.Drawing.Size(1074, 766);
            this.GrBoxClinica.TabIndex = 5;
            this.GrBoxClinica.TabStop = false;
            this.GrBoxClinica.Text = "Clinica ZANONI";
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(11, 361);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.RowHeadersWidth = 82;
            this.dataGridPacientes.RowTemplate.Height = 33;
            this.dataGridPacientes.Size = new System.Drawing.Size(1052, 239);
            this.dataGridPacientes.TabIndex = 11;
            // 
            // dataGridEspecialistas
            // 
            this.dataGridEspecialistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEspecialistas.Location = new System.Drawing.Point(6, 81);
            this.dataGridEspecialistas.Name = "dataGridEspecialistas";
            this.dataGridEspecialistas.RowHeadersWidth = 82;
            this.dataGridEspecialistas.RowTemplate.Height = 33;
            this.dataGridEspecialistas.Size = new System.Drawing.Size(1057, 244);
            this.dataGridEspecialistas.TabIndex = 10;
            // 
            // btnAsignarTurnoClinica
            // 
            this.btnAsignarTurnoClinica.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTurnoClinica.Location = new System.Drawing.Point(11, 627);
            this.btnAsignarTurnoClinica.Name = "btnAsignarTurnoClinica";
            this.btnAsignarTurnoClinica.Size = new System.Drawing.Size(250, 112);
            this.btnAsignarTurnoClinica.TabIndex = 6;
            this.btnAsignarTurnoClinica.Text = "Asignar Turno Clinica";
            this.btnAsignarTurnoClinica.UseVisualStyleBackColor = true;
            this.btnAsignarTurnoClinica.Click += new System.EventHandler(this.btnAsignarTurno_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(788, 627);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(243, 112);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAsigTurnoDerivado
            // 
            this.btnAsigTurnoDerivado.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsigTurnoDerivado.Location = new System.Drawing.Point(348, 627);
            this.btnAsigTurnoDerivado.Name = "btnAsigTurnoDerivado";
            this.btnAsigTurnoDerivado.Size = new System.Drawing.Size(309, 112);
            this.btnAsigTurnoDerivado.TabIndex = 12;
            this.btnAsigTurnoDerivado.Text = "Asignar turno derivado";
            this.btnAsigTurnoDerivado.UseVisualStyleBackColor = true;
            this.btnAsigTurnoDerivado.Click += new System.EventHandler(this.btnAsigTurnoDerivado_Click);
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
        private System.Windows.Forms.Button btnAsignarTurnoClinica;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridPacientes;
        private System.Windows.Forms.DataGridView dataGridEspecialistas;
        private System.Windows.Forms.Button btnAsigTurnoDerivado;
    }
}

