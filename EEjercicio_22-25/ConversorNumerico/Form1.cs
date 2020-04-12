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

namespace ConversorNumerico
{
    public partial class Form1 : Form
    {
        NumeroBinario bin;
        NumeroDecimal dec;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResultadoBin.Enabled = false;
            txtResultadoDec.Enabled = false;
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {   
            
            if(txtBinario.Text.Contains("1") || txtBinario.Text.Contains("0"))
            {
                txtResultadoDec.Text = Conversor.BinarioDecimal(txtBinario.Text).ToString();
            }
            else
            {
                txtResultadoDec.Text = "invalido";
            }
        }


        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            double aux;
            if(double.TryParse(txtDecimal.Text, out aux))
            {
               txtResultadoBin.Text = Conversor.DecimalBinario(aux).ToString();
            }
            
        }
    }
}
