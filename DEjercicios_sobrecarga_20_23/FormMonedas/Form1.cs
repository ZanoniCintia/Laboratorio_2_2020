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

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCotizacionEuro.Text, out aux))
            {
                Euro.SetCotizacion(aux);
            }
            else
            {
                this.txtCotizacionEuro.Focus();
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double aux;
            if(double.TryParse(txtCotizacionDolar.Text,out aux))
            {
                Dolar.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionDolar.Focus();
            }
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double aux;
            if(double.TryParse(txtCotizacionPeso.Text,out aux))
            {
                Pesos.SetCotizacion(aux);
            }
            else
            {
                txtCotizacionPeso.Focus();
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double aux;
            if (Double.TryParse(txtEuro.Text, out aux))
            {
                Euro eurs = new Euro(aux);
                Pesos pes = (Pesos)eurs;
                Dolar dolares = (Dolar)eurs;

                txtEuroAEuro.Text = eurs.GetCantidad().ToString();
                txtEuroADolar.Text = dolares.GetCantidad().ToString();
                txtEuroAPeso.Text = pes.GetCantidad().ToString();
            }
            else
            {
                txtEuro.Focus();
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double aux;
            if (Double.TryParse(txtEuro.Text, out aux))
            {
                Dolar dolares = new Dolar(aux);
                Pesos pes = (Pesos)dolares;
                Euro euros = (Euro)dolares;

                txtDolarAEuro.Text = euros.GetCantidad().ToString();
                txtDolarADolar.Text = dolares.GetCantidad().ToString();
                txtDolarAPeso.Text = pes.GetCantidad().ToString();
            }
            else
            {
                txtDolar.Focus();
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double aux;
            if (Double.TryParse(txtEuro.Text, out aux))
            {
                Pesos pes = new Pesos(aux);
                Dolar dolares = (Dolar)pes;
                Euro euros = (Euro)pes;

                txtPesoAEuro.Text = euros.GetCantidad().ToString();
                txtPesoADolar.Text = dolares.GetCantidad().ToString();
                txtPesoAPeso.Text = pes.GetCantidad().ToString();
            }
            else
            {
                txtPeso.Focus();
            }
        }
    }
}
