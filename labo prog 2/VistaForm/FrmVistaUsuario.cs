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
        FrmCarrito carrito;
        string mensaje;
        public FrmVistaUsuario()
        {
            InitializeComponent();
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

        private void FrmVistaUsuario_Load(object sender, EventArgs e)
        {
            this.lblSaludo.Text = Mensaje;
            carrito = new FrmCarrito();
            switch (cmbCategoria.Text)
            {
                case "Iluminacion":
                    cmbCategoria.DataSource = Enum.GetValues(typeof(Iluminacion.TipoIluminaria));
                    
                    break;
                case "Herramientas":
                    cmbCategoria.DataSource = Enum.GetValues(typeof(Herramienta.TipoHerramientas));
                    
                    break;
                case "Insumos":
                    cmbCategoria.DataSource = Enum.GetValues(typeof(Insumos.TipoInsumos));
                    
                    break;
            }
            cmbAmbito.DataSource = Enum.GetValues(typeof(TipoDeAmbito));
            
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
           carrito.ShowDialog();
        }

        private void listBoxStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
