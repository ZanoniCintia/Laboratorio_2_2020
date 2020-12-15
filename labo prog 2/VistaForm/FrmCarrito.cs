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
    public partial class FrmCarrito : Form
    {
        Pedido pedido;
        
        public FrmCarrito()
        {
            InitializeComponent();
            pedido = new Pedido();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarCarrito_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
           // richTextBoxTotal.Text = pedido.PrecioTotal();
        }
    }
}
