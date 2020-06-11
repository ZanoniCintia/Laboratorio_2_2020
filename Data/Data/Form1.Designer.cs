namespace Data
{
    partial class FrmSql
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
            this.data = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelfiltro = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.rbAlto = new System.Windows.Forms.RadioButton();
            this.rbBaja = new System.Windows.Forms.RadioButton();
            this.rbModif = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.data.Location = new System.Drawing.Point(32, 220);
            this.data.Margin = new System.Windows.Forms.Padding(0);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersVisible = false;
            this.data.RowHeadersWidth = 82;
            this.data.RowTemplate.Height = 33;
            this.data.Size = new System.Drawing.Size(1044, 629);
            this.data.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Palatino Linotype", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(610, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(158, 94);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelfiltro
            // 
            this.labelfiltro.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.labelfiltro.AutoSize = true;
            this.labelfiltro.BackColor = System.Drawing.Color.Transparent;
            this.labelfiltro.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfiltro.ForeColor = System.Drawing.Color.Black;
            this.labelfiltro.Location = new System.Drawing.Point(334, 81);
            this.labelfiltro.Name = "labelfiltro";
            this.labelfiltro.Size = new System.Drawing.Size(159, 43);
            this.labelfiltro.TabIndex = 3;
            this.labelfiltro.Text = "Curso ";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.BackgroundImage = global::Data.Properties.Resources.miniimages;
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(1738, 670);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(177, 161);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.rbModif);
            this.groupBox1.Controls.Add(this.rbBaja);
            this.groupBox1.Controls.Add(this.rbAlto);
            this.groupBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1149, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 620);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(321, 127);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(203, 33);
            this.cmbCurso.TabIndex = 6;
            // 
            // rbAlto
            // 
            this.rbAlto.AutoSize = true;
            this.rbAlto.Font = new System.Drawing.Font("Perpetua Titling MT", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlto.Location = new System.Drawing.Point(29, 135);
            this.rbAlto.Name = "rbAlto";
            this.rbAlto.Size = new System.Drawing.Size(178, 56);
            this.rbAlto.TabIndex = 0;
            this.rbAlto.TabStop = true;
            this.rbAlto.Text = "Alta";
            this.rbAlto.UseVisualStyleBackColor = true;
//            this.rbAlto.CheckedChanged += new System.EventHandler(this.rbAlto_CheckedChanged);
            // 
            // rbBaja
            // 
            this.rbBaja.AutoSize = true;
            this.rbBaja.Font = new System.Drawing.Font("Perpetua Titling MT", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBaja.Location = new System.Drawing.Point(29, 233);
            this.rbBaja.Name = "rbBaja";
            this.rbBaja.Size = new System.Drawing.Size(171, 56);
            this.rbBaja.TabIndex = 1;
            this.rbBaja.TabStop = true;
            this.rbBaja.Text = "Baja";
            this.rbBaja.UseVisualStyleBackColor = true;
//            this.rbBaja.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbModif
            // 
            this.rbModif.AutoSize = true;
            this.rbModif.Font = new System.Drawing.Font("Perpetua Titling MT", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModif.Location = new System.Drawing.Point(29, 334);
            this.rbModif.Name = "rbModif";
            this.rbModif.Size = new System.Drawing.Size(407, 56);
            this.rbModif.TabIndex = 2;
            this.rbModif.TabStop = true;
            this.rbModif.Text = "Modificacion";
            this.rbModif.UseVisualStyleBackColor = true;
          //  this.rbModif.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(29, 425);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(203, 123);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Data.Properties.Resources.LittleMermaidM;
            this.ClientSize = new System.Drawing.Size(1949, 874);
            this.ControlBox = false;
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.labelfiltro);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelfiltro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.RadioButton rbModif;
        private System.Windows.Forms.RadioButton rbBaja;
        private System.Windows.Forms.RadioButton rbAlto;
        private System.Windows.Forms.Button btnOk;
    }
}

