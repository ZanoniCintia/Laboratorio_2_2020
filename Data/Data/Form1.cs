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
    public partial class FrmSql : Form
    {
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader misDatosDeBase;
        DataTable miTabla;
        List<string> cursos;
        public FrmSql()
        {
            miConexion = new SqlConnection("Data Source = .\\ ; Database = utnfra; Trusted_Connection = true");
            miComando = new SqlCommand();
            miTabla = new DataTable();
            cursos = new List<string>();
            
            InitializeComponent();
        }
        public List<string> CargarCmbCursos()
        {
            try
            {

                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT distinct curso FROM Alumnos ";
                miConexion.Open();
                misDatosDeBase = miComando.ExecuteReader();

                while (misDatosDeBase.Read())
                {
                    cursos.Add(misDatosDeBase["curso"].ToString());
                }


                return cursos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                miConexion.Close();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCurso.DataSource = CargarCmbCursos(); 
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                data.DataSource = null;
                miTabla.Clear();
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT * FROM Alumnos WHERE curso = @cursofiltro";

                miComando.Parameters.Clear();
                miComando.Parameters.Add(new SqlParameter("cursofiltro",cmbCurso.SelectedValue));
                

                miConexion.Open();

                misDatosDeBase = miComando.ExecuteReader();

                miTabla.Load(misDatosDeBase);
                
                data.DataSource = miTabla;
                


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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

       

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rbAlto.Checked)
            {
                FrmAlta alta = new FrmAlta();
                alta.Show();



            }else if (rbBaja.Checked)
            {


            }else if (rbModif.Checked)
            {


            }

        }
    }
}
