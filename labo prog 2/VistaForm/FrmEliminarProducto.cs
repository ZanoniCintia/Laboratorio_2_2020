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
    public partial class FrmEliminarProducto : Form
    {
        Inventario lista;
        public FrmEliminarProducto(Inventario lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

      
        public List<Producto> Lista
        {
            get { return this.lista.Productos; }
            
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        { 
                richTextBoxMostrar.Text = lista.BuscarProducto(txtNombre.Text, (TipoDeAmbito)cmbAmbito.SelectedItem);
         
        }

      

        private void FrmEliminarProducto_Load(object sender, EventArgs e)
        {
            cmbAmbito.DataSource = Enum.GetValues(typeof(TipoDeAmbito));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if(lista.EliminarProductoStock(txtNombre.Text, (TipoDeAmbito)cmbAmbito.SelectedItem) == true)
            {
                MessageBox.Show("Producto eliminado de la lista");
                richTextBoxMostrar.Text = "";
                txtNombre.Text = "";
                
            }
            else
            {
                MessageBox.Show("Producto no se encuentra en la lista. Compruebe que los datos sean correctos e intente nuevamente");

            }

        }
    }
}
