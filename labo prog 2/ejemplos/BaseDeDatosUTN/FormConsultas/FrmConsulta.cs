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

namespace FormConsultas
{
    public partial class FrmConsulta : Form
    {
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader miCarrier;
        /// <summary>
        /// objeto que formatea a tipo tabla los valores.
        /// </summary>
        DataTable miTabla;

        public FrmConsulta()
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
        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            dGVSQL.ReadOnly = true;
            dGVSQL.RowHeadersVisible = false;
            dGVSQL.ColumnHeadersVisible = true;
            dGVSQL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVSQL.AllowUserToAddRows = false;
            cmbCurso.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ///Cargo la conexión con los parametros:
                ///Data Source: El nombre del servidor
                ///Database: La base de datos a conectarse
                ///Trusted_Connection: permitirá la conexión.
                ///
                ///Creo mi comando.
                miConexion = new SqlConnection("Data Source = .\\SQLEXPRESS; Database = utnfra; Trusted_Connection = True;");
                miComando = new SqlCommand();
                /// creo una nueva tabla
                miTabla = new DataTable();
                /// Enlazo mi comando a la conexión a la base de datos que voy a usar.
                miComando.Connection = miConexion;
                dGVSQL.DataSource = null;
                miTabla.Rows.Clear();
                /// Define que mi comando irá en forma de texto 
                /// CommandText nos permite cargar la query en mi comando. 
                miComando.CommandType = CommandType.Text;
                ///agrego un parametro por medio del @ y posteriormente le asigno un valor
                miComando.CommandText = "Select * from Alumnos Where curso = @cursoAFiltrar ";
                /// limpio el parametro por si acarrea un valor anterior
                miComando.Parameters.Clear();
                ///cargo un nuevo valor generando mi parametro
                miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", (cmbCurso.SelectedValue)));
                /// Otra versión ^
                /// SqlParameter miParametro = new SqlParameter("cursoAFiltrar", 1);
                /// miComando.Parameters.Add(miParametro);

                ///Abre la conexión a la base de datos
                miConexion.Open();
                miCarrier = miComando.ExecuteReader();
                miTabla.Load(miCarrier);
                dGVSQL.DataSource = miTabla;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            finally
            {
                miConexion.Close();
            }


            //SqlCommand sqlCommand = new SqlCommand();
            //miComando.Connection = miConexion;
            //miComando.CommandType = CommandType.Text;

            //miComando.CommandText = "insert into Alumnos values(@legajo,@nombre,@apellido,@cursoAFiltrar");

            //miComando.Parameters.Add(new SqlParameter("legajo", int.Parse(txtCursoFiltro.Text)));
            //miComando.Parameters.Add(new SqlParameter("nombre", "Subject"));
            //miComando.Parameters.Add(new SqlParameter("apellido", "Test"));
            //miComando.Parameters.Add(new SqlParameter("CursoAFiltrar", 1));

            //miConexion.Open();

            /////Ejecuta y en el caso del insert nos va a traer la cantidad de inserts que hizo.
            //int cantInsert = miComando.ExecuteNonQuery();

            //MessageBox.Show("Cantidad de lineas insertadas: " + cantInsert);

            //miConexion.Close();
        }


    }
}
