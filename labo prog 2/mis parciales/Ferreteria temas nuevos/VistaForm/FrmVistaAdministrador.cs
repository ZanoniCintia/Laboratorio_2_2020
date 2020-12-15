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
    public partial class FrmVistaAdministrador : Form
    {

        Tienda miTienda;
        FrmCargaDeProducto carga;
        FrmEliminarProducto eliminar;
        FrmListar listaStock;
        FrmCarrito pedidoFinal;
        FrmControlPedidosRealizadosAdministrador pedidos;

        /// <summary>
        /// propiedad de escritura para cargar la tienda
        /// para poder compartir la misma lista desde login
        /// </summary>
        public Tienda CargarTienda
        {
           
            set
            {
                miTienda = value;
            }
        } 

        /// <summary>
        /// propiedad de escritura para retornar la tienda
        /// para poder compartir la misma lista desde login
        /// </summary>
        public Tienda RetornarTienda 
        { 
            get
            {
                return this.miTienda;
            }
        }

        public FrmVistaAdministrador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// abre el formulario para poder agregar productos al stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            carga.ShowDialog();
        }

        /// <summary>
        /// inicio del formulario con la instancia de todos los formularios a utilizar
        /// invoca el metodo de clase para tener pedidos ya confirmados de prueba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVistaAdministrador_Load(object sender, EventArgs e)
        {
            carga = new FrmCargaDeProducto(this.miTienda.Inventario);
            eliminar = new FrmEliminarProducto(this.miTienda.Inventario);
            listaStock = new FrmListar(this.miTienda.Inventario);
            pedidoFinal = new FrmCarrito();
            pedidos = new FrmControlPedidosRealizadosAdministrador();
            this.CargarDatosPedidoPrueba();
        }

        /// <summary>
        /// listas de pedidos con productos pre cargados
        /// </summary>
        private void CargarDatosPedidoPrueba()
        {
            #region CargarHistorialPedidos
            List<Producto> lisProd = new List<Producto>();
            List<Producto> lisProd2 = new List<Producto>();
            List<Producto> lisProd3 = new List<Producto>();
            lisProd.Add(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 1", 1, 25, 4, "rojo", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            lisProd.Add(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 2", 2, 25, 4, "rojo", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            lisProd.Add(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 3", 3, 25, 4, "rojo", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            lisProd.Add(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 4", 4, 25, 4, "azul", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            lisProd.Add(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 5", 5, 25, 4, "azul", TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            lisProd.Add(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Marca 6", 6, 25, 4, "verde", TipoDeAmbito.Hogar, TipoDeUsuario.Experto));
            Pedido.HistorialPedidos.Add(new Pedido(lisProd));
            lisProd2.Add(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 0", 50, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            lisProd2.Add(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 1", 51, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            lisProd2.Add(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 2", 52, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            lisProd2.Add(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 3", 53, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            lisProd2.Add(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 4", 54, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            Pedido.HistorialPedidos.Add(new Pedido(lisProd2));
            lisProd3.Add(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 0", 70, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            lisProd3.Add(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 1", 71, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            lisProd3.Add(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 2", 72, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            lisProd3.Add(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 3", 73, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            Pedido.HistorialPedidos.Add(new Pedido(lisProd3));
            #endregion
        }

        /// <summary>
        /// si hay datos para eliminar se accede al formulario correspondiente para realizar la eliminacion del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (HayElementos("eliminar"))
                eliminar.ShowDialog();
        }

        /// <summary>
        /// si hay elementos para listar accede al formulario que lista el stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (HayElementos("listar"))
                listaStock.ShowDialog();
        }


        /// <summary>
        /// controla que la lista contenga elementos, muestra un mensaje segun su funcion
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        private bool HayElementos(string mensaje)
        {
            if (!(this.miTienda.Inventario.Productos.Count > 0))
            {
                MessageBox.Show($"No hay elementos para {mensaje}");
                return false;
            }
            return true;
        }


        /// <summary>
        /// muestra un mensaje con las ganancias de la tienda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcularGanancia_Click(object sender, EventArgs e)
        {
       
            MessageBox.Show(Tienda.CalcularGananciaPorPedidos());
        }

        /// <summary>
        /// sale del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// accede al formulario que contiene la lista de pedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPedidos_Click(object sender, EventArgs e)
        {
          
            pedidos.ShowDialog();
        }
    }
}
