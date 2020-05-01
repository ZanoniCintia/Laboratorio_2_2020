namespace FormSistemaSolar
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.txtTiempoOrbita = new System.Windows.Forms.TextBox();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.cmbTipoPlanetas = new System.Windows.Forms.ComboBox();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.numRotacionP = new System.Windows.Forms.NumericUpDown();
            this.numCantLunas = new System.Windows.Forms.NumericUpDown();
            this.numCompOrbita = new System.Windows.Forms.NumericUpDown();
            this.numRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnAgregarSatelite = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantLunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompOrbita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del planeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo en completar orbita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo en completar rotacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de lunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de planetas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(736, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Planeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(736, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre del satelite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(736, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tiempo en completar orbita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(736, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(324, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tiempo en completar rotacion";
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(394, 36);
            this.txtNombrePlaneta.Multiline = true;
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(288, 42);
            this.txtNombrePlaneta.TabIndex = 9;
            // 
            // txtTiempoOrbita
            // 
            this.txtTiempoOrbita.Location = new System.Drawing.Point(394, 114);
            this.txtTiempoOrbita.Multiline = true;
            this.txtTiempoOrbita.Name = "txtTiempoOrbita";
            this.txtTiempoOrbita.Size = new System.Drawing.Size(288, 42);
            this.txtTiempoOrbita.TabIndex = 10;
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(1080, 114);
            this.txtNombreSatelite.Multiline = true;
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(288, 42);
            this.txtNombreSatelite.TabIndex = 11;
            // 
            // cmbTipoPlanetas
            // 
            this.cmbTipoPlanetas.FormattingEnabled = true;
            this.cmbTipoPlanetas.Location = new System.Drawing.Point(394, 364);
            this.cmbTipoPlanetas.Name = "cmbTipoPlanetas";
            this.cmbTipoPlanetas.Size = new System.Drawing.Size(288, 33);
            this.cmbTipoPlanetas.TabIndex = 12;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(1080, 45);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(288, 33);
            this.cmbPlaneta.TabIndex = 13;
            // 
            // numRotacionP
            // 
            this.numRotacionP.Location = new System.Drawing.Point(394, 205);
            this.numRotacionP.Name = "numRotacionP";
            this.numRotacionP.Size = new System.Drawing.Size(288, 31);
            this.numRotacionP.TabIndex = 14;
            // 
            // numCantLunas
            // 
            this.numCantLunas.Location = new System.Drawing.Point(394, 285);
            this.numCantLunas.Name = "numCantLunas";
            this.numCantLunas.Size = new System.Drawing.Size(288, 31);
            this.numCantLunas.TabIndex = 15;
            // 
            // numCompOrbita
            // 
            this.numCompOrbita.Location = new System.Drawing.Point(1080, 205);
            this.numCompOrbita.Name = "numCompOrbita";
            this.numCompOrbita.Size = new System.Drawing.Size(288, 31);
            this.numCompOrbita.TabIndex = 16;
            // 
            // numRotacionSatelite
            // 
            this.numRotacionSatelite.Location = new System.Drawing.Point(1080, 281);
            this.numRotacionSatelite.Name = "numRotacionSatelite";
            this.numRotacionSatelite.Size = new System.Drawing.Size(288, 31);
            this.numRotacionSatelite.TabIndex = 17;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(41, 427);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(641, 91);
            this.btnAgregarP.TabIndex = 18;
            this.btnAgregarP.Text = "Agregar planeta";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // btnAgregarSatelite
            // 
            this.btnAgregarSatelite.Location = new System.Drawing.Point(741, 427);
            this.btnAgregarSatelite.Name = "btnAgregarSatelite";
            this.btnAgregarSatelite.Size = new System.Drawing.Size(627, 91);
            this.btnAgregarSatelite.TabIndex = 19;
            this.btnAgregarSatelite.Text = "Agregar satelite";
            this.btnAgregarSatelite.UseVisualStyleBackColor = true;
            this.btnAgregarSatelite.Click += new System.EventHandler(this.btnAgregarSatelite_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(41, 542);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(1327, 85);
            this.btnMostrar.TabIndex = 20;
            this.btnMostrar.Text = "Mostrar informacion";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(41, 653);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(1327, 88);
            this.btnMover.TabIndex = 21;
            this.btnMover.Text = "Mover astros";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1405, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(315, 705);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1755, 766);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregarSatelite);
            this.Controls.Add(this.btnAgregarP);
            this.Controls.Add(this.numRotacionSatelite);
            this.Controls.Add(this.numCompOrbita);
            this.Controls.Add(this.numCantLunas);
            this.Controls.Add(this.numRotacionP);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.cmbTipoPlanetas);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.txtTiempoOrbita);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zanoni Cintia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantLunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompOrbita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.TextBox txtTiempoOrbita;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.ComboBox cmbTipoPlanetas;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.NumericUpDown numRotacionP;
        private System.Windows.Forms.NumericUpDown numCantLunas;
        private System.Windows.Forms.NumericUpDown numCompOrbita;
        private System.Windows.Forms.NumericUpDown numRotacionSatelite;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnAgregarSatelite;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

