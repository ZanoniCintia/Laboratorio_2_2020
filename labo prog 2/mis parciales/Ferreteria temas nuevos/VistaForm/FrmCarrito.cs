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
        Pedido pedidoFinalizado;
        FrmCantidad cantidad;


        public Pedido PropPedido
        {
            get { return this.pedidoFinalizado; }
            set { this.pedidoFinalizado = value; }
        }

        public FrmCarrito()
        {
            InitializeComponent();
            pedidoFinalizado = new Pedido();
        }




        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarCarrito_Click(object sender, EventArgs e)
        {

            Producto aux = this.pedidoFinalizado.Pedidos[listBoxCarrito.SelectedIndex];


            FrmCantidad frmCant = new FrmCantidad();

         
                aux.CantidadPedidaCliente = frmCant.RetornarCantidad;

                if (aux - this.pedidoFinalizado)
                {
                    MessageBox.Show("El producto fue eliminado");
                    CargarDatos();
                }
          
        }

        private void CargarDatos()
        {
            this.listBoxCarrito.DataSource = null;
            this.listBoxCarrito.Items.Clear();
            this.listBoxCarrito.DataSource = this.pedidoFinalizado.Pedidos;
            this.richTextBoxTotal.Text = pedidoFinalizado.PrecioTotal(this.pedidoFinalizado.Pedidos).ToString();
        }
        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            CargarDatos();

           
        }

  
        private void btnComprar_Click(object sender, EventArgs e)
        {
            
            this.listBoxCarrito.DataSource = null;
            this.listBoxCarrito.Items.Clear();
            MessageBox.Show($"Pedido confirmado Total : ${ pedidoFinalizado.PrecioTotal(this.pedidoFinalizado.Pedidos).ToString()}");
            Pedido.HistorialPedidos.Add(this.pedidoFinalizado);
         
            
        }
    }
}
