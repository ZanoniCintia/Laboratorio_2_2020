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

namespace FormABM
{
    public partial class FormAlta : Form
    {
        SqlConnection miConexion;
        SqlCommand miComandoI;
        SqlCommand miComandoS;
        SqlDataReader miCarrier;
        string legajo;
        public FormAlta()
        {

            InitializeComponent();

            SqlConnection miConexion;
            SqlCommand miComando;
            SqlDataReader miCarrier;
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
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                miConexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Database = utnfra; Trusted_Connection = True;");
                miComandoI = new SqlCommand();

                SqlCommand sqlCommand = new SqlCommand();
                miComandoI.Connection = miConexion;
                miComandoI.CommandType = CommandType.Text;

                miComandoI.CommandText = "insert into Alumnos values(@nombre,@apellido,@curso)";

                miComandoI.Parameters.Add(new SqlParameter("nombre", txtNombre.Text));
                miComandoI.Parameters.Add(new SqlParameter("apellido", txtApellido.Text));
                miComandoI.Parameters.Add(new SqlParameter("curso", cmbCurso.SelectedValue));

                miConexion.Open();

                ///Ejecuta y en el caso del insert nos va a traer la cantidad de inserts que hizo.
                int cantInsert = miComandoI.ExecuteNonQuery();


                miComandoS = new SqlCommand();
                miComandoS.Connection = miConexion;
                miComandoS.CommandType = CommandType.Text;
                miComandoS.Parameters.Add(new SqlParameter("nombreS", txtNombre.Text));
                miComandoS.Parameters.Add(new SqlParameter("apellidoS", txtApellido.Text));
                miComandoS.Parameters.Add(new SqlParameter("cursoS", cmbCurso.SelectedValue));
                miComandoS.CommandText = "Select Legajo from Alumnos Where nombre = @nombreS and apellido = @apellidoS and curso = @cursoS";
                miCarrier = miComandoS.ExecuteReader();

                string nombreVal = txtNombre.Text;
                string apellidoVal = txtApellido.Text;

                while (miCarrier.Read())
                {
                    legajo = miCarrier["Legajo"].ToString();
                }

                MessageBox.Show("Se ha insertado el alumno " + txtNombre.Text  + " " + txtApellido.Text + 
                    " del curso: " + cmbCurso.SelectedValue + " su número de legajo es: " + legajo);
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
