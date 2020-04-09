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

namespace FormMonedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizacionPeso.Text = Pesos.GetCotizacion().ToString();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (txtCotizacionEuro.Enabled)
            {
                btnLockCotizacion.ImageIndex = 1;
                txtCotizacionPeso.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionEuro.Enabled = false;
            }
            else
            {
                btnLockCotizacion.ImageIndex = 0;
                txtCotizacionPeso.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionEuro.Enabled = true;
            }
        }
    }
}
