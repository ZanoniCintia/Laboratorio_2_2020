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
    public partial class FrmControlPedidosRealizadosAdministrador : Form
    {
        FrmCarrito pedidoFinal;
        Pedido auxPedido;
        
        
        
        public FrmControlPedidosRealizadosAdministrador()
        {
            InitializeComponent();
            
            pedidoFinal = new FrmCarrito();


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// inicializa el listbox con la lista estatica de historial de pedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmControlPedidosRealizadosAdministrador_Load(object sender, EventArgs e)
        {
            this.listBoxPedidosConfir.DataSource = Pedido.HistorialPedidos;
        }

        /// <summary>
        /// muestra el detalle del pedido seleccionado del listbox
        /// recorriendo la lista de pedidos del listbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
           
            StringBuilder sb = new StringBuilder();
            Pedido aux = Pedido.HistorialPedidos[listBoxPedidosConfir.SelectedIndex];

            foreach (Producto item in aux.Pedidos)
            {
                sb.AppendLine(item.ToString());
            }

            MessageBox.Show(sb.ToString());


        }
    }
}
