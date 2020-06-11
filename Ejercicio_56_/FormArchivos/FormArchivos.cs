using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormArchivos
{
    public partial class FormArchivos : Form
    {
        string ultimo = null;
        public FormArchivos()
        {
            InitializeComponent();
        }

        private void abrir_Click(object sender, EventArgs e)
        {

                OpenFileDialog abrir = new OpenFileDialog();
                abrir.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(abrir.FileName))
                    richEscribe.Text = reader.ReadToEnd();
                    
                }
                               
            

        }

        private void guardar_Click(object sender, EventArgs e)
        {
                 SaveFileDialog abrir = new SaveFileDialog();

                abrir.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (abrir.ShowDialog() == DialogResult.OK)
                {

                    using (StreamWriter writer = new StreamWriter(abrir.FileName, File.Exists(abrir.FileName)))
                    writer.Write(richEscribe.Text); 
                }

            
        }

        private void GuardarComo_Click(object sender, EventArgs e)
        {
            this.guardar_Click(sender,e);
        }

        private void richEscribe_TextChanged(object sender, EventArgs e)
        {
            toolCaracteres.Text = richEscribe.TextLength.ToString();
        }
    }
}
