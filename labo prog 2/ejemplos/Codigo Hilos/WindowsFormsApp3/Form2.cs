using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        string prox;
        Form3 f3;
        public Form2()
        {
            f3 = new Form3();
            f3.Show();
            InitializeComponent();
        }

        public void ActualizarDato(Perro dato)
        {
              
            if (this.richTextBox1.InvokeRequired)
            {
                this.richTextBox1.BeginInvoke((MethodInvoker)delegate ()
                {
                  f3.ActualizarDato(this.richTextBox1.Text);

                    this.richTextBox1.Text = dato.DatosCompletos() ;
                }
                );
            }
            else
            {
                this.richTextBox1.Text = dato.DatosCompletos();
            }

        }

    }
}
