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
    public partial class FrmCargaDeProducto : Form
    {
        Inventario producto;
        
        public FrmCargaDeProducto(Inventario lista)
        {
            InitializeComponent();
            this.producto = lista;
            
        }

        public List<Producto> Lista
        {
            get { return this.producto.Productos; }

        }

     


        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (cmbTipoDeProducto.Text)
            {
                case "Iluminacion":
                    Iluminacion iluminacion = new Iluminacion((Iluminacion.TipoIluminaria)cmbEspecifico.SelectedItem,txtNombre.Text, int.Parse( txtCodigo.Text),double.Parse(txtPrecio.Text),int.Parse( txtStock.Text),txtColor.Text,(TipoDeAmbito) cmbTipoAmbito.SelectedItem,(TipoDeUsuario) cmbTipoUsuario.SelectedItem);
                    producto.AgregarProductoAlStock(iluminacion);
                    MessageBox.Show("Producto agregado a la lista de stock");
                    break;
                case "Herramientas":
                    Herramienta herramientas = new Herramienta((Herramienta.TipoHerramientas)cmbEspecifico.SelectedItem,txtNombre.Text, int.Parse(txtCodigo.Text),double.Parse(txtPrecio.Text),int.Parse(txtStock.Text),(TipoDeAmbito)cmbTipoAmbito.SelectedItem, (TipoDeUsuario)cmbTipoUsuario.SelectedItem);
                    producto.AgregarProductoAlStock(herramientas);
                    MessageBox.Show("Producto agregado a la lista de stock");
                    break;
                case "Insumos":
                    Insumos insumos = new Insumos((Insumos.TipoInsumos)cmbEspecifico.SelectedItem, txtNombre.Text,int.Parse(txtPrecio.Text),double.Parse(txtPrecio.Text),int.Parse(txtStock.Text), (TipoDeAmbito)cmbTipoAmbito.SelectedItem, (TipoDeUsuario)cmbTipoUsuario.SelectedItem);
                    producto.AgregarProductoAlStock(insumos);
                    MessageBox.Show("Producto agregado a la lista de stock");
                    break;


            }

            
        }

        private void cmbTipoDeProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoDeProducto.Text)
            {
                case "Iluminacion":                    
                    cmbEspecifico.DataSource = Enum.GetValues(typeof(Iluminacion.TipoIluminaria));
                    txtColor.Enabled = true;
                    break;
                case "Herramientas":
                    cmbEspecifico.DataSource = Enum.GetValues(typeof(Herramienta.TipoHerramientas));
                    txtColor.Enabled = false;
                    break;
                case "Insumos":
                    cmbEspecifico.DataSource = Enum.GetValues(typeof(Insumos.TipoInsumos));
                    txtColor.Enabled = false;
                    break;


            }
        }

        private void FrmCargaDeProducto_Load(object sender, EventArgs e)
        {
            cmbTipoAmbito.DataSource = Enum.GetValues(typeof(TipoDeAmbito));
            cmbTipoUsuario.DataSource = Enum.GetValues(typeof(TipoDeUsuario));
        }

      

        
    }
}
