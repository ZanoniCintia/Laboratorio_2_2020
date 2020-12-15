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
    public partial class FrmLogInFerreteria : Form
    {
        Tienda tienda;
        FrmVistaAdministrador frmVistaAdministrador;
        FrmVistaUsuario frmVistaUsuario;

        /// <summary>
        /// constructor instancia formularios
        /// </summary>
        public FrmLogInFerreteria()
        {
            InitializeComponent();
            tienda = new Tienda();
            frmVistaAdministrador = new FrmVistaAdministrador();
            frmVistaUsuario = new FrmVistaUsuario();
        }

        /// <summary>
        /// copia los datos para el ingreso administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "Administrador";
            txtContraseña.Text = "eldueño";
        }

        /// <summary>
        /// copia los datos para el ingreso comprador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "Comprador";
            txtContraseña.Text = "123456";
        }

        /// <summary>
        /// segun quien se ingreso en el login abre el formulario correspondiente
        /// de lo contrario muestra mensaje de error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            switch (txtUsuario.Text)
            {
                case "Administrador":
                    frmVistaAdministrador.CargarTienda = this.tienda;
                    frmVistaAdministrador.ShowDialog();
                    this.tienda = frmVistaAdministrador.RetornarTienda;
                    break;

                case "Comprador":
                    frmVistaUsuario.CargarTienda = this.tienda;
                    frmVistaUsuario.Mensaje = "Bienvenido Comprador";
                    frmVistaUsuario.ShowDialog();
                    this.tienda = frmVistaUsuario.RetornarTienda;
                    break;

                default:
                    MessageBox.Show("El usuario ingresado no existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        /// <summary>
        /// carga los datos de prueba 
        /// muestra el mensaje de bienvenida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogInFerreteria_Load(object sender, EventArgs e)
        { 
            this.CargarDatosPrueba();
            frmVistaUsuario.Mensaje = txtUsuario.Text;
        }

        /// <summary>
        /// cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// productos de prueba
        /// </summary>
        private void CargarDatosPrueba()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory+"Archivo.Xml";
              #region Iluminacion
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 1", 1, 25, 4, "rojo", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 2", 2, 25, 4, "rojo", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 3", 3, 25, 4, "rojo", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 4", 4, 25, 4, "azul", TipoDeAmbito.Profesional, TipoDeUsuario.Principiante));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Marca 5", 5, 25, 4, "azul", TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Marca 6", 6, 25, 4, "verde", TipoDeAmbito.Hogar, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Luz", 7, 25, 4, "verde", TipoDeAmbito.Hogar, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Luz", 8, 25, 4, "verde", TipoDeAmbito.Hogar, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Luz", 9, 25, 4, "verde", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueInterior, "Luz", 10, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.ApliqueExterior, "Luz", 1, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 12, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 13, 25, 4, "amarillo", TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 14, 25, 4, "amarillo", TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 15, 25, 4, "amarillo", TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 16, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.Focos, "Luz", 17, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.LamparasPie, "Luz", 18, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.LamparasPie, "Luz", 19, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
            this.tienda.Inventario.AgregarProductoAlStock(new Iluminacion(Iluminacion.TipoIluminaria.LamparasPie, "Luz", 20, 25, 4, "azul", TipoDeAmbito.Hogar, TipoDeUsuario.Principiante));
            
            #endregion
            
              #region Herramienta
            this.tienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 0", 50, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 1", 51, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 2", 52, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 3", 53, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 4", 54, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 5", 55, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 6", 56, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            this.tienda.Inventario.AgregarProductoAlStock(new Herramienta(Herramienta.TipoHerramientas.Amoladora, "Corta 7", 57, 456, 7, TipoDeAmbito.Profesional, TipoDeUsuario.Experto));
            
            #endregion
            
              #region Insumos
            this.tienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 0", 70, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 1", 71, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 2", 72, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 3", 73, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 4", 74, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 5", 75, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            this.tienda.Inventario.AgregarProductoAlStock(new Insumos(Insumos.TipoInsumos.CintaMetrica, "pega 6", 76, 76, 3, TipoDeAmbito.Hogar, TipoDeUsuario.Experimentado));
            #endregion

            ClaseSerializacion.GuardarXml<Tienda>(ruta,tienda);

            

        }

    }
}
