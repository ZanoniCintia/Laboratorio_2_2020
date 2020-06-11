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

namespace Data
{
    public partial class FrmAlta : Form
    {
        FrmSql sql;
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader reader;
      
       
        public FrmAlta()
        {
            sql = new FrmSql();
            miConexion = new SqlConnection("Data Source = .\\ ; Database = utnfra; Trusted_Connection = true");
            miComando = new SqlCommand();
           
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.Parameters.Add(new SqlParameter("nombre", tbNombre.Text));
                miComando.Parameters.Add(new SqlParameter("apellido", tbApellido.Text));
                miComando.Parameters.Add(new SqlParameter("curso", cmbCurso.SelectedValue));
                miComando.CommandText = "INSERT INTO Alumnos VALUES (@nombre,@apellido,@curso)";
                miConexion.Open();
                miComando.ExecuteNonQuery();

              //  miComando.Parameters.Clear();
               

                
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT legajo FROM Alumnos WHERE nombre=@nombre AND apellido=@apellido AND curso=@curso";
                reader = miComando.ExecuteReader();
                string legajo="";
                while (reader.Read())
                {
                    legajo = reader["legajo"].ToString();
                }
                MessageBox.Show(legajo+tbNombre.Text + " " + tbApellido.Text +" "+ cmbCurso.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miConexion.Close();
            }
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbCurso.DataSource = sql.CargarCmbCursos();

        }
    }
}
