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
        
        public FrmVistaAdministrador()
        {
            InitializeComponent();
            miTienda = new Tienda();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            carga.ShowDialog();
            
        }

        public void CargarDatosPrueba()
        {
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 1", 1, 25, 4, "rojo", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 2", 2, 25, 4, "rojo", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 3", 3, 25, 4, "rojo", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 4", 4, 25, 4, "azul", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 5", 5, 25, 4, "azul", TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Marca 6", 6, 25, 4, "verde", TipoDeAmbito.Hogar,TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Luz", 7, 25, 4, "verde", TipoDeAmbito.Hogar,TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Luz", 8, 25, 4, "verde", TipoDeAmbito.Hogar,TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Luz", 9, 25, 4, "verde", TipoDeAmbito.Hogar,TipoDeUsuario.Principiante));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Luz", 10, 25, 4, "azul", TipoDeAmbito.Hogar,TipoDeUsuario.Principiante));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Luz", 1, 25, 4, "azul", TipoDeAmbito.Hogar,TipoDeUsuario.Principiante));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 12, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 13, 25, 4, "amarillo", TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 14, 25, 4, "amarillo", TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 15, 25, 4, "amarillo", TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 16, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 17, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.LamparasPie, "Luz", 18, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.LamparasPie, "Luz", 19, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
            this.miTienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.LamparasPie, "Luz", 20, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
           
            this.miTienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 0", 50, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 1", 51, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 2", 52, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 3", 53, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 4", 54, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 5", 55, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 6", 56, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.miTienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 7", 57, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
           
            this.miTienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 0", 70, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 1", 71, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 2", 72, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 3", 73, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 4", 74, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 5", 75, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.miTienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 6", 76, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
                                                                                              
        }

        private void FrmVistaAdministrador_Load(object sender, EventArgs e)
        {
            carga = new FrmCargaDeProducto(this.miTienda.Inventario);
            eliminar = new FrmEliminarProducto(this.miTienda.Inventario);
            listaStock = new FrmListar(this.miTienda.Inventario);
        }


        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (HayElementos("eliminar"))
                eliminar.ShowDialog();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (HayElementos("listar"))
                listaStock.ShowDialog();
        }

        private bool HayElementos(string mensaje)
        {
            if(! (this.miTienda.Inventario.Productos.Count > 0))
            {
                MessageBox.Show($"No hay elementos para {mensaje}");
                return false;
            }
            return true;
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            this.CargarDatosPrueba();
            btnCargarDatos.Enabled = false;
        }

        private void btnCalcularGanancia_Click(object sender, EventArgs e)
        {
           MessageBox.Show( miTienda.CarcularGananciaTotal().ToString());
        }
    }
}
