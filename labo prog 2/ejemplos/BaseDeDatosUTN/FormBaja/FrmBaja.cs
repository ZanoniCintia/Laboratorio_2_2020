using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormBaja
{
    public partial class FrmBaja : Form
    {
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader miCarrier;
        string auxNombre;
        string auxApellido;
        string auxCurso;
        public FrmBaja()
        {
            InitializeComponent();
        }

        private void FrmBaja_Load(object sender, EventArgs e)
        {
            this.btnBaja.Enabled = false;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            ///Cargo la conexión con los parametros:
            ///Data Source: El nombre del servidor
            ///Database: La base de datos a conectarse
            ///Trusted_Connection: permitirá la conexión.
            ///
            ///Creo mi comando.
            miConexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Database = utnfra; Trusted_Connection = True;");
            miComando = new SqlCommand();

            /// Enlazo mi comando a la conexión a la base de datos que voy a usar.
            miComando.Connection = miConexion;

            /// Define que mi comando irá en forma de texto 
            /// CommandText nos permite cargar la query en mi comando. 
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = "Select * from Alumnos where legajo = @legajo";

            miComando.Parameters.Add(new SqlParameter("legajo", txtLegajo.Text));

            ///Abre la conexión a la base de datos
            miConexion.Open();

            /// Ejecuta la lectura de los datos del SQL
            miCarrier = miComando.ExecuteReader();

            /// De todos los datos que trajo va a guardar nombre y apellido hasta que no haya
            while (miCarrier.Read())
            {
                auxNombre = miCarrier["Nombre"].ToString();
                auxApellido = miCarrier["Apellido"].ToString();
                auxCurso = miCarrier["curso"].ToString();

                rTBDatos.Text = auxNombre + " " + auxApellido + " " + auxCurso;
            }
            this.btnBaja.Enabled = true;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                miConexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Database = utnfra; Trusted_Connection = True;");
                miComando = new SqlCommand();

                SqlCommand sqlCommand = new SqlCommand();
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;

                miComando.CommandText = "delete Alumnos where legajo = @legajo";

                miComando.Parameters.Add(new SqlParameter("legajo", txtLegajo.Text));

                miConexion.Open();

                ///Ejecuta y en el caso del insert nos va a traer la cantidad de inserts que hizo.
                int cantDeleted = miComando.ExecuteNonQuery();

                MessageBox.Show("Se ha eliminado el legajo: " + txtLegajo.Text + " satisfactoriamente. ");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            finally
            {
                miConexion.Close();
            }
        }
    }
}
