namespace ClinicaZanoni
{
    partial class FrmProximoPaciente
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
            this.lblProximoPaciente = new System.Windows.Forms.Label();
            this.rTBoxProximoPaciente = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblProximoPaciente
            // 
            this.lblProximoPaciente.AutoSize = true;
            this.lblProximoPaciente.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximoPaciente.Location = new System.Drawing.Point(28, 55);
            this.lblProximoPaciente.Name = "lblProximoPaciente";
            this.lblProximoPaciente.Size = new System.Drawing.Size(237, 38);
            this.lblProximoPaciente.TabIndex = 0;
            this.lblProximoPaciente.Text = "Proximo Paciente";
            // 
            // rTBoxProximoPaciente
            // 
            this.rTBoxProximoPaciente.Location = new System.Drawing.Point(35, 117);
            this.rTBoxProximoPaciente.Name = "rTBoxProximoPaciente";
            this.rTBoxProximoPaciente.Size = new System.Drawing.Size(724, 152);
            this.rTBoxProximoPaciente.TabIndex = 1;
            this.rTBoxProximoPaciente.Text = "";
      
            // 
            // ProximoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaZanoni.Properties.Resources.clinicap;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.ControlBox = false;
            this.Controls.Add(this.rTBoxProximoPaciente);
            this.Controls.Add(this.lblProximoPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 20);
            this.Name = "ProximoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.ProximoPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProximoPaciente;
        private System.Windows.Forms.RichTextBox rTBoxProximoPaciente;
    }
}