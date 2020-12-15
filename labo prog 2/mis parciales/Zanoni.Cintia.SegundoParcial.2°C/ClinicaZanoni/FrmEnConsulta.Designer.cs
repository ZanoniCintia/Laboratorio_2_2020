namespace ClinicaZanoni.Properties
{
    partial class FrmEnConsulta
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
            this.rTBoxEnConsulta = new System.Windows.Forms.RichTextBox();
            this.lblProximoPaciente = new System.Windows.Forms.Label();
            this.lblTurnosFinalizados = new System.Windows.Forms.Label();
            this.rTBoxTurnosFinalizados = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTBoxEnConsulta
            // 
            this.rTBoxEnConsulta.Location = new System.Drawing.Point(6, 42);
            this.rTBoxEnConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rTBoxEnConsulta.Name = "rTBoxEnConsulta";
            this.rTBoxEnConsulta.Size = new System.Drawing.Size(355, 81);
            this.rTBoxEnConsulta.TabIndex = 0;
            this.rTBoxEnConsulta.Text = "";
            // 
            // lblProximoPaciente
            // 
            this.lblProximoPaciente.AutoSize = true;
            this.lblProximoPaciente.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximoPaciente.Location = new System.Drawing.Point(8, 9);
            this.lblProximoPaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProximoPaciente.Name = "lblProximoPaciente";
            this.lblProximoPaciente.Size = new System.Drawing.Size(93, 21);
            this.lblProximoPaciente.TabIndex = 1;
            this.lblProximoPaciente.Text = "En Consulta";
            // 
            // lblTurnosFinalizados
            // 
            this.lblTurnosFinalizados.AutoSize = true;
            this.lblTurnosFinalizados.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnosFinalizados.Location = new System.Drawing.Point(4, 134);
            this.lblTurnosFinalizados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurnosFinalizados.Name = "lblTurnosFinalizados";
            this.lblTurnosFinalizados.Size = new System.Drawing.Size(141, 21);
            this.lblTurnosFinalizados.TabIndex = 2;
            this.lblTurnosFinalizados.Text = "Turnos finalizados";
            // 
            // rTBoxTurnosFinalizados
            // 
            this.rTBoxTurnosFinalizados.Location = new System.Drawing.Point(7, 166);
            this.rTBoxTurnosFinalizados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rTBoxTurnosFinalizados.Name = "rTBoxTurnosFinalizados";
            this.rTBoxTurnosFinalizados.Size = new System.Drawing.Size(354, 87);
            this.rTBoxTurnosFinalizados.TabIndex = 3;
            this.rTBoxTurnosFinalizados.Text = "";
            // 
            // FrmEnConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaZanoni.Properties.Resources.clinicap;
            this.ClientSize = new System.Drawing.Size(389, 266);
            this.Controls.Add(this.rTBoxTurnosFinalizados);
            this.Controls.Add(this.lblTurnosFinalizados);
            this.Controls.Add(this.lblProximoPaciente);
            this.Controls.Add(this.rTBoxEnConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 200);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEnConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBoxEnConsulta;
        private System.Windows.Forms.Label lblProximoPaciente;
        private System.Windows.Forms.Label lblTurnosFinalizados;
        private System.Windows.Forms.RichTextBox rTBoxTurnosFinalizados;
    }
}