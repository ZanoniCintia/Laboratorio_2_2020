using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace PrincipalForm
{
    public partial class VentasForm : Form
    {
        Comiqueria comic;
        Producto producto;
        public VentasForm(Comiqueria comiqueria,Producto producto)
        {
            InitializeComponent();
            this.comic = comiqueria;
            this.producto = producto;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = producto.Descripcion;
            numericUpDownCantidad.Minimum = 1;
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Precio final: ${0}", producto.Precio.ToString());
            lblPreciofinal.Text = cadena.ToString();
        }

        private void lblPreciofinal_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCantidad.Minimum = 1;
            double auxiliar = (double)numericUpDownCantidad.Value;
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Precio Final: ${0} ", producto.Precio * (double)numericUpDownCantidad.Value);
            lblPreciofinal.Text = cadena.ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (numericUpDownCantidad.Value >= 1 && numericUpDownCantidad.Value <= producto.Stock)
            {
                comic.Vender(producto, (int)numericUpDownCantidad.Value);

                this.DialogResult = DialogResult.OK;
            }
            else if (numericUpDownCantidad.Value > producto.Stock)
            {
                MessageBox.Show("Supero la cantidad de stock disponible, debe disminuir la cantidad de unidades a vender", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
