using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonica
{
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        
        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        
        public Centralita Centralita
        {
            get { return this.centralita; }
            
        }




        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text = "Nro destino";
            textNroOrigen.Text = "Nro origen";

        }



        #region BotonesTextBox1
        private void btn1_Click_1(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text += "#";
            if (textBoxNroDestino.Text.IndexOf('#')==0)
            {
                comboBoxFranja.Enabled = true;
                
            }
        }



        #endregion

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random auxRandom = new Random();
            float duracion = auxRandom.Next(1, 50);
            float costo = (float)(auxRandom.Next(50, 56)/100);
            Llamada llamada;
            string mensaje = string.Empty;
            if (textBoxNroDestino.Text != "Nro destino" && textNroOrigen.Text != "Nro Origen")
            {   
                if(textBoxNroDestino.Text == "#")
                {
                    comboBoxFranja.Enabled = false;
                    //carga
                    comboBoxFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                    //lectura
                    Provincial.Franja franja;
                    Enum.TryParse(comboBoxFranja.SelectedValue.ToString(), out franja);
                    llamada = new Provincial(franja,textNroOrigen.Text,duracion,textBoxNroDestino.Text);
                }else
                {
                    //carga
                    llamada = new Local(textNroOrigen.Text, duracion,textBoxNroDestino.Text, costo);
                }

                centralita.Llamadas.Add(llamada);
                mensaje = "Llamada cargada exitosamente";

            }
            else
            {
                mensaje = "La llamada no pudo ser cargada";
            }
            MessageBox.Show(mensaje);
        }

      
    }
}
