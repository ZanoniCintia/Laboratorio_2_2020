using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormConsultas;
using FormABM;
using FormBaja;
using FormModif;

namespace FormBase
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta consulta = new FrmConsulta();
            consulta.ShowDialog();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormAlta alta = new FormAlta();
            alta.ShowDialog();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FrmBaja baja = new FrmBaja();
            baja.ShowDialog();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            FrmModif modif = new FrmModif();
            modif.ShowDialog();
        }
    }
}
