namespace FormCantina
{
    partial class FormCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCantina));
            this.radioButtonAgua = new System.Windows.Forms.RadioButton();
            this.radioButtonCerveza = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.numeContenido = new System.Windows.Forms.NumericUpDown();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barra1 = new ControlCantina.Barra();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonAgua
            // 
            this.radioButtonAgua.AutoSize = true;
            this.radioButtonAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAgua.Location = new System.Drawing.Point(35, 91);
            this.radioButtonAgua.Name = "radioButtonAgua";
            this.radioButtonAgua.Size = new System.Drawing.Size(103, 33);
            this.radioButtonAgua.TabIndex = 0;
            this.radioButtonAgua.TabStop = true;
            this.radioButtonAgua.Text = "Agua";
            this.radioButtonAgua.UseVisualStyleBackColor = true;
            // 
            // radioButtonCerveza
            // 
            this.radioButtonCerveza.AutoSize = true;
            this.radioButtonCerveza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCerveza.Location = new System.Drawing.Point(35, 208);
            this.radioButtonCerveza.Name = "radioButtonCerveza";
            this.radioButtonCerveza.Size = new System.Drawing.Size(139, 33);
            this.radioButtonCerveza.TabIndex = 1;
            this.radioButtonCerveza.TabStop = true;
            this.radioButtonCerveza.Text = "Cerveza";
            this.radioButtonCerveza.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.numeContenido);
            this.groupBox1.Controls.Add(this.numCapacidad);
            this.groupBox1.Controls.Add(this.txtBoxMarca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonAgua);
            this.groupBox1.Controls.Add(this.radioButtonCerveza);
            this.groupBox1.Location = new System.Drawing.Point(12, 518);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1302, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(838, 178);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(251, 63);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(838, 97);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(251, 39);
            this.cmbTipo.TabIndex = 9;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // numeContenido
            // 
            this.numeContenido.Location = new System.Drawing.Point(580, 208);
            this.numeContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numeContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeContenido.Name = "numeContenido";
            this.numeContenido.Size = new System.Drawing.Size(128, 31);
            this.numeContenido.TabIndex = 8;
            this.numeContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(350, 211);
            this.numCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(133, 31);
            this.numCapacidad.TabIndex = 7;
            this.numCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(350, 93);
            this.txtBoxMarca.Multiline = true;
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(358, 43);
            this.txtBoxMarca.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contenido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capacidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(833, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Botella tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca";
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(21, 6);
            this.barra1.Margin = new System.Windows.Forms.Padding(6);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(1284, 522);
            this.barra1.TabIndex = 3;
            // 
            // FormCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 786);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCantina";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCantina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAgua;
        private System.Windows.Forms.RadioButton radioButtonCerveza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown numeContenido;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.TextBox txtBoxMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ControlCantina.Barra barra1;
    }
}

