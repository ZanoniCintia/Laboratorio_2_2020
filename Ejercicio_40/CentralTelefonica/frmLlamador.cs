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
        TextBox auxFoco=new TextBox();
        
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
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.comboBoxFranja.Text = "Franja horaria";
            this.comboBoxFranja.Enabled = false;
            textBoxNroDestino.Text ="Nro destino";
            textNroOrigen.Text ="Nro origen";

        }



        #region BotonesTextBox1
        private void btn1_Click_1(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino"))
                {
                    textBoxNroDestino.Text = "1";
                }
                else
                {
                    textBoxNroDestino.Text += "1";
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen"))
                {
                    textNroOrigen.Text = "1";
                }
                else
                {
                    textNroOrigen.Text += "1";
                }
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino"))
                {
                    textBoxNroDestino.Text = "2";
                }
                else
                {
                    textBoxNroDestino.Text += "2";
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen"))
                {
                    textNroOrigen.Text = "2";
                }
                else
                {
                    textNroOrigen.Text += "2";
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino"))
                {
                    textBoxNroDestino.Text = "3";
                }
                else
                {
                    textBoxNroDestino.Text += "3";
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen"))
                {
                    textNroOrigen.Text = "3";
                }
                else
                {
                    textNroOrigen.Text += "3";
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino"))
                {
                    textBoxNroDestino.Text = "4";
                }
                else
                {
                    textBoxNroDestino.Text += "4";
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen"))
                {
                    textNroOrigen.Text = "4";
                }
                else
                {
                    textNroOrigen.Text += "4";
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino"))
                {
                    textBoxNroDestino.Text = "5";
                }
                else
                {
                    textBoxNroDestino.Text += "5";
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen"))
                {
                    textNroOrigen.Text = "5";
                }
                else
                {
                    textNroOrigen.Text += "5";
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino"))
                {
                    textBoxNroDestino.Text = "6";
                }
                else
                {
                    textBoxNroDestino.Text += "6";
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen"))
                {
                    textNroOrigen.Text = "6";
                }
                else
                {
                    textNroOrigen.Text += "6";
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino"))
                {
                    textBoxNroDestino.Text = "7";
                }
                else
                {
                    textBoxNroDestino.Text += "7";
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen"))
                {
                    textNroOrigen.Text = "7";
                }
                else
                {
                    textNroOrigen.Text += "7";
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino"))
                {
                    textBoxNroDestino.Text = "8";
                }
                else
                {
                    textBoxNroDestino.Text += "8";
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen"))
                {
                    textNroOrigen.Text = "8";
                }
                else
                {
                    textNroOrigen.Text += "8";
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino"))
                {
                    textBoxNroDestino.Text = "9";
                }
                else
                {
                    textBoxNroDestino.Text += "9";
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen"))
                {
                    textNroOrigen.Text = "9";
                }
                else
                {
                    textNroOrigen.Text += "9";
                }
            }
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino") ||
                    textBoxNroDestino.Text == string.Empty)
                {
                    textBoxNroDestino.Text = "*";
                }
                else
                {

                    MessageBox.Show
                    ("Solo puede agregar '*' al principio de la llamada");
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen") ||
                    textNroOrigen.Text == string.Empty)
                {
                    textNroOrigen.Text = "*";
                }
                else
                {

                    MessageBox.Show
                    ("Solo puede agregar '*' al principio de la llamada");
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino"))
                {
                    textBoxNroDestino.Text = "0";
                }
                else
                {
                    textBoxNroDestino.Text += "0";
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen"))
                {
                    textNroOrigen.Text = "0";
                }
                else
                {
                    textNroOrigen.Text += "0";
                }
            }
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (auxFoco == textBoxNroDestino)
            {
                if (textBoxNroDestino.Text.Contains("Nro Destino") ||
                    textBoxNroDestino.Text == string.Empty)
                {
                    textBoxNroDestino.Text = "#";
                    if (textBoxNroDestino.Text.IndexOf('#') == 0)
                    {
                        comboBoxFranja.Enabled = true;
                    }
                    else
                    {
                        comboBoxFranja.Enabled = false;
                    }
                }
                else
                {

                    MessageBox.Show
                    ("Solo puede agregar '#' al principio de la llamada");
                }
            }
            if (auxFoco == textNroOrigen)
            {
                if (textNroOrigen.Text.Contains("Nro Origen") ||
                    textBoxNroDestino.Text == string.Empty)
                {
                    textNroOrigen.Text = "#";
                }
                else
                {

                    MessageBox.Show
                    ("Solo puede agregar '#' al principio de la llamada");
                }
            }

        }



        #endregion

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            
            Random auxRandom = new Random();
            float duracion = auxRandom.Next(1, 50);
            float costo = (float)auxRandom.Next(50, 56);
            costo /= 100;
            
            
            if ((textBoxNroDestino.Text != "Nro destino" && textNroOrigen.Text != "Nro origen")
                && (textBoxNroDestino.Text !="" && textNroOrigen.Text != ""))
            {
                try
                {
                    if (textBoxNroDestino.Text.IndexOf('#') == 0)
                    {
                        if (comboBoxFranja.Text != "Franja horaria")
                        {
                            comboBoxFranja.Enabled = false;

                            //lectura
                            Provincial.Franja franja;
                            Enum.TryParse(comboBoxFranja.SelectedValue.ToString(), out franja);
                            Provincial llamadaProv = new Provincial(franja, textNroOrigen.Text, duracion, textBoxNroDestino.Text);
                            centralita += llamadaProv;
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una franja");

                        }
                    }
                    else
                    {
                        //carga
                        Local llamadaLocal = new Local(textNroOrigen.Text, duracion, textBoxNroDestino.Text, costo);
                        centralita += llamadaLocal;
                    }


                    MessageBox.Show("Llamada cargada exitosamente");
                }
                catch (CentralitaException ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }

            }
            else
            {
                MessageBox.Show("Llamada  no cargada ");
            }
            
        }

      

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            //carga
            auxFoco.Text = "Nro destino";
            //textBoxNroDestino.Text = "Nro destino";
            comboBoxFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            
        }

        private void textBoxNroDestino_Enter(object sender, EventArgs e)
        {
            textBoxNroDestino.Text = "";
            auxFoco = textBoxNroDestino;
            
        }

        private void textNroOrigen_Enter(object sender, EventArgs e)
        {
            textNroOrigen.Text = "";
            auxFoco = textNroOrigen;
            
        }
    }
}
