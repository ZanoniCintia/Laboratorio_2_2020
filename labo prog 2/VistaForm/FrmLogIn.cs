using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class FrmLogInFerreteria : Form
    {
        FrmVistaAdministrador frmVistaAdministrador;
        FrmVistaUsuario frmVistaUsuario;
        public FrmLogInFerreteria()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "admin";
            txtContraseña.Text = "soyElrey";
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "profe";
            txtContraseña.Text = "ElMejor";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            switch (txtUsuario.Text)
            {
                case "admin":
                    frmVistaAdministrador.ShowDialog();
                    break;
                case "profe":
                    frmVistaUsuario.ShowDialog();
                    break;
                default:
                    MessageBox.Show("El usuario ingresado no existe", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void FrmLogInFerreteria_Load(object sender, EventArgs e)
        {
            frmVistaAdministrador = new FrmVistaAdministrador();
            
            frmVistaUsuario = new FrmVistaUsuario();
            frmVistaUsuario.Mensaje = txtUsuario.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
