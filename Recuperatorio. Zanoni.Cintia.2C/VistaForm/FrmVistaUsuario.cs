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
    public partial class FrmVistaUsuario : Form
    {

        Tienda miTienda;
        FrmCarrito carrito;

        string mensaje;
        public FrmVistaUsuario()
        {
            InitializeComponent();
            carrito = new FrmCarrito();
            cmbAmbito.DataSource = Enum.GetValues(typeof(TipoDeAmbito));
            cmbAmbito.SelectedIndex = 0;
        }

        public Tienda CargarTienda
        {
            set { miTienda = value; }
        }
        public Tienda RetornarTienda
        {
            get
            {
                return this.miTienda;
            }
        }

        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
            set
            {
                this.mensaje = value;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ExisteEnElCombo(string aux)
        {
            foreach (string item in cmbCategoria.Items)
            {
                if (item == aux)
                    return true;
            }
            return false;
        }
        /// <summary>
        ///  Carga de items en comboBox
        /// </summary>
        private void CargarComboBoxs()
        {
            cmbCategoria.Items.Clear();

            foreach (Producto item in this.miTienda.Inventario.Productos)
            {
                if (!ExisteEnElCombo(item.GetType().Name.ToString()))
                {
                    cmbCategoria.Items.Add(item.GetType().Name.ToString());
                }
            }
            cmbCategoria.SelectedIndex = 0;


        }

        private void FrmVistaUsuario_Load(object sender, EventArgs e)
        {
            this.lblSaludo.Text = mensaje;
            this.CargarComboBoxs();
             CargarListBox();

        }



        private void CargarListBox()
        {
            this.cmbAmbito.Text = "Todos";
            this.cmbCategoria.Text = "Todos";
            this.listBoxStock.DataSource = miTienda.Inventario.Productos;
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito aux = carrito;
            carrito.ShowDialog();
        }

        private void btnInstruccionUso_Click(object sender, EventArgs e)
        {

            MessageBox.Show(this.miTienda.Inventario.Productos[listBoxStock.SelectedIndex].InstruccionesDeUso());

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto aux = this.miTienda.Inventario.Productos[listBoxStock.SelectedIndex];

            FrmCantidad frmCant = new FrmCantidad();

            if (frmCant.ShowDialog() == DialogResult.OK)
              {
                aux.CantidadPedidaCliente = frmCant.RetornarCantidad;
                this.miTienda.Inventario.Productos[listBoxStock.SelectedIndex].Stock -= aux.CantidadPedidaCliente;

                if (aux + this.carrito.PropPedido)
                {
                     MessageBox.Show("Agregado al carrito");
                }
            }
          

        }

        private void CargarLista(string filtro)
        {
            List<Producto> auxLista = new List<Producto>();
          

            this.listBoxStock.DataSource = null;
            this.listBoxStock.Items.Clear();
            
            
        
                
                    foreach (Producto auxProducto in miTienda.Inventario.Productos)
                    {
                        if (auxProducto.GetType().Name.ToString() == cmbCategoria.SelectedItem.ToString())
                        {
                            if (cmbAmbito.SelectedItem.ToString() == "Hogar" && auxProducto.Ambito.ToString() == "Hogar")
                            {
                                auxLista.Add(auxProducto);
                            }
                            else if (cmbAmbito.SelectedItem.ToString() == "Profesional" && auxProducto.Ambito.ToString() == "Profesional") 
                            {
                                auxLista.Add(auxProducto);
                            }

                        }
                    }
                    this.listBoxStock.DataSource = auxLista;
                    
                
                   
                    
            }
        


        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarListBox();
       
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbAmbito.Text == "Todos")
                this.cmbAmbito.Text = "Profesional";

            CargarLista(this.cmbCategoria.SelectedItem.ToString());
        }

        private void cmbAmbito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(this.cmbCategoria.SelectedItem is null))
              CargarLista(this.cmbCategoria.SelectedItem.ToString());
        }
    }
}
