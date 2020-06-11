namespace FormArchivos
{
    partial class FormArchivos
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
            this.richEscribe = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolCaracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEscribe
            // 
            this.richEscribe.Location = new System.Drawing.Point(12, 56);
            this.richEscribe.Name = "richEscribe";
            this.richEscribe.Size = new System.Drawing.Size(761, 483);
            this.richEscribe.TabIndex = 0;
            this.richEscribe.Text = "";
            this.richEscribe.TextChanged += new System.EventHandler(this.richEscribe_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrir,
            this.guardar,
            this.GuardarComo});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrir
            // 
            this.abrir.Name = "abrir";
            this.abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrir.Size = new System.Drawing.Size(472, 44);
            this.abrir.Text = "Abrir";
            this.abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // guardar
            // 
            this.guardar.Name = "guardar";
            this.guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardar.Size = new System.Drawing.Size(472, 44);
            this.guardar.Text = "Guardar";
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // GuardarComo
            // 
            this.GuardarComo.Name = "GuardarComo";
            this.GuardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.GuardarComo.Size = new System.Drawing.Size(472, 44);
            this.GuardarComo.Text = "Guardar como";
            this.GuardarComo.Click += new System.EventHandler(this.GuardarComo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCaracteres});
            this.statusStrip1.Location = new System.Drawing.Point(0, 644);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(785, 42);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolCaracteres
            // 
            this.toolCaracteres.Name = "toolCaracteres";
            this.toolCaracteres.Size = new System.Drawing.Size(125, 32);
            this.toolCaracteres.Text = "Caracteres";
            // 
            // FormArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 686);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richEscribe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richEscribe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrir;
        private System.Windows.Forms.ToolStripMenuItem guardar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolCaracteres;
        private System.Windows.Forms.ToolStripMenuItem GuardarComo;
    }
}

