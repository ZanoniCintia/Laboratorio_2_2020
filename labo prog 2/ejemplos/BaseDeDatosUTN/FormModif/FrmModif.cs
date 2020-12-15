using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormModif
{
    public partial class FrmModif : Form
    {
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader miCarrier;
        string auxNombre;
        string auxApellido;
        string auxCurso;
        public FrmModif()
        {
            InitializeComponent();
        }

        private void FrmModif_Load(object sender, EventArgs e)
        {
            this.btnModif.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            cmbCurso.Enabled = false;

            List<string> listaCursos = new List<string>();


            miConexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Database = utnfra; Trusted_Connection = True;");
            miComando = new SqlCommand();

            /// Enlazo mi comando a la conexión a la base de datos que voy a usar.
            miComando.Connection = miConexion;

            /// Define que mi comando irá en forma de texto 
            /// CommandText nos permite cargar la query en mi comando. 
            miComando.CommandType = CommandType.Text;
            ///Select distinct > Evita traer duplicados de la base de datos
            miComando.CommandText = "Select distinct curso from Alumnos";

            ///Abre la conexión a la base de datos
            miConexion.Open();

            /// Ejecuta la lectura de los datos del SQL
            miCarrier = miComando.ExecuteReader();

            /// De todos los datos que trajo va a guardar nombre y apellido hasta que no haya
            while (miCarrier.Read())
            {
                listaCursos.Add(miCarrier["curso"].ToString());
            }

            cmbCurso.DataSource = listaCursos;
            cmbCurso.Text = string.Empty;

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerif_Click(object sender, EventArgs e)
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

                txtNombre.Text = auxNombre;
                txtApellido.Text = auxApellido;
                cmbCurso.Text = auxCurso;

                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                cmbCurso.Enabled = true;
                this.btnModif.Enabled = true;
            }

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {

                miConexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Database = utnfra; Trusted_Connection = True;");
                miComando = new SqlCommand();

                SqlCommand sqlCommand = new SqlCommand();
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;

                miComando.CommandText = "update Alumnos set nombre = @nombre, apellido = @apellido, curso = @curso where legajo = @legajo";
                miComando.Parameters.Add(new SqlParameter("nombre", txtNombre.Text));
                miComando.Parameters.Add(new SqlParameter("apellido", txtApellido.Text));
                miComando.Parameters.Add(new SqlParameter("curso", (cmbCurso.SelectedValue)));
                miComando.Parameters.Add(new SqlParameter("legajo", (txtLegajo.Text)));

                miConexion.Open();

                ///Ejecuta y en el caso del insert nos va a traer la cantidad de inserts que hizo.
                int cantInsert = miComando.ExecuteNonQuery();

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
                }

                MessageBox.Show("Se han modificado los datos del alumno a los siguientes: \n Nombre: " + txtNombre.Text + "\n Apellido: " + txtApellido.Text +
                " \n Curso: " + cmbCurso.SelectedValue + " \n Legajo: " + txtLegajo.Text);
                this.btnModif.Enabled = false;
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
