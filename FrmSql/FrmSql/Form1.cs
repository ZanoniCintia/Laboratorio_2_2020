using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrmSql
{
    public partial class FrmSql : Form
    {
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader traeDatos;
        public FrmSql()
        {
            miConexion = new SqlConnection("Data Source = . ; DataBase = utnfra ; trusted_connection = true");
            miComando = new SqlCommand();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string aux;
            string aux2;
            try
            {
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT * FROM Alumnos";

                miConexion.Open();

                traeDatos = miComando.ExecuteReader();

                while (traeDatos.Read())
                {
                    aux = traeDatos["nombre"].ToString();
                    aux2 = traeDatos["apellido"].ToString();
                }


            } catch (Exception ex)
            {
                // ex.Message;
            }
            finally
            {
                miConexion.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
