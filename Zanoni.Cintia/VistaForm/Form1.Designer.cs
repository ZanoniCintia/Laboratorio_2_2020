namespace VistaForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.numDNI = new System.Windows.Forms.NumericUpDown();
            this.numExperiencia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Experiencia";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(110, 348);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(169, 70);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(330, 348);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(169, 70);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(245, 25);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 41);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(245, 78);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(254, 41);
            this.txtApellido.TabIndex = 8;
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(245, 144);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(254, 31);
            this.numEdad.TabIndex = 9;
            // 
            // numDNI
            // 
            this.numDNI.Location = new System.Drawing.Point(245, 205);
            this.numDNI.Name = "numDNI";
            this.numDNI.Size = new System.Drawing.Size(254, 31);
            this.numDNI.TabIndex = 10;
            // 
            // numExperiencia
            // 
            this.numExperiencia.Location = new System.Drawing.Point(245, 261);
            this.numExperiencia.Name = "numExperiencia";
            this.numExperiencia.Size = new System.Drawing.Size(254, 31);
            this.numExperiencia.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.numExperiencia);
            this.Controls.Add(this.numDNI);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FormDt";
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.NumericUpDown numDNI;
        private System.Windows.Forms.NumericUpDown numExperiencia;
    }
}

