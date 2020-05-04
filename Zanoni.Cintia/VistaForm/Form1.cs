using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        DirectorTecnico dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {   
          
                dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)numEdad.Value, (int)numDNI.Value, (int)numExperiencia.Value);
                MessageBox.Show("Se a creado el DT!");


        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text== string.Empty && txtApellido.Text==string.Empty
                && numExperiencia.Value==0 && numEdad.Value==0 && numDNI.Value == 0)
            {
                MessageBox.Show("Aun no se a creado el DT del formulario");
            }
            
            
            if(dt != null && dt.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto");
            }
            else
            {
                MessageBox.Show("El DT no es apto");
            }
        }
    }
}
