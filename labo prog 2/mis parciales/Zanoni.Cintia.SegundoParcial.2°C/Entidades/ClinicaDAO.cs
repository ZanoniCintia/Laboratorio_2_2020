using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.NetworkInformation;


namespace Entidades
{
    public static class ClinicaDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader reader;        
        private static DataTable tablaPacientes;
        private static DataTable tablaEspecialistas;
  
        /// <summary>
        /// constructor estatico 
        /// </summary>
        static ClinicaDAO()
        {
            string connectionString = @"Server = .\ ; Database = ClinicaUtn ; Trusted_Connection = true;";
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            tablaEspecialistas = new DataTable();
            tablaPacientes = new DataTable();               
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
         
            
        }


        /// <summary>
        /// recibe parametro del tipo  turno
        /// Guarda el parametro ingresado en una tabla de la base de datos
        /// </summary>
        /// <param name="t"></param>
        public static void IngresarTurno(Turno t)
        {

            try
            {
                conexion.Open();
                string comandoString = "INSERT INTO Turnos  " +
                    "VALUES ( @idPaciente, @idEspecialista, @observacionesTurno ,@fechaTurno);";

                comando.Parameters.Clear();
                comando.Parameters.Add("idPaciente", System.Data.SqlDbType.Int);
                comando.Parameters.Add("idEspecialista", System.Data.SqlDbType.Int);
                comando.Parameters.Add("observacionesTurno", System.Data.SqlDbType.VarChar);
                comando.Parameters.Add("fechaTurno", System.Data.SqlDbType.VarChar);
                
                comando.Parameters[0].Value = t.IdPaciente;
                comando.Parameters[1].Value = t.IdEspecialista;
                comando.Parameters[2].Value = t.Observacion;
                comando.Parameters[3].Value = t.Fecha;
                comando.CommandText = comandoString;
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error en base de datos", e); ;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();

            }
            

        }
     

        /// <summary>
        /// trae la tabla pacientes completa y guarda cada uno en una lista
        /// </summary>
        public static List<Paciente> SeleccionarPacientes()
        {
            List<Paciente> aux = new List<Paciente>();

            string comandoString = "SELECT * FROM Pacientes;";
            comando.CommandText = comandoString;
            ConexionOpen();
            using (reader = comando.ExecuteReader())
            {
                tablaPacientes.Load(reader);
            }
            using (reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id, edad;
                    string apellido, nombre, sexo, direccion;
                    Cobertura obraSocial;

                    id = (int)reader["IdPaciente"];
                    nombre = reader["Nombre"].ToString();
                    apellido = reader["Apellido"].ToString();
                    edad = (int)reader["Edad"];
                    sexo = reader["Sexo"].ToString();
                    direccion = reader["Direccion"].ToString();
                    Enum.TryParse(reader["Obrasocial"].ToString(), out obraSocial);


                    aux.Add(new Paciente(id, nombre, apellido, edad, sexo, direccion, obraSocial));
                    

                }

            }
            ConexionClose();

            return aux;
        }


        /// <summary>
        /// trae la tabla especialistas completa y guarda cada uno en una lista
        /// </summary>
        public static List<Especialista> SeleccionarEspecialistas()
        {
            List<Especialista> aux = new List<Especialista>();

            string comandoString = "SELECT * FROM Especialistas;";
            comando.CommandText = comandoString;
            ConexionOpen();
            using (reader= comando.ExecuteReader())
            {
                tablaEspecialistas.Load(reader);
            }
            using (reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    
                    int id, edad;
                    string apellido, nombre, sexo, direccion;
                    Especialidad especialidad;

                    id = (int)reader["IdEspecialista"];
                    nombre = reader["Nombre"].ToString();
                    apellido = reader["Apellido"].ToString();
                    edad = (int)reader["Edad"];
                    sexo = reader["Sexo"].ToString();
                    direccion = reader["Direccion"].ToString();
                    Enum.TryParse(reader["Especialidad"].ToString(),out especialidad);


                    aux.Add(new Especialista(id,nombre,apellido,edad,sexo,direccion,especialidad));
                    
                }
            }
            ConexionClose();
            return aux;
        }

        /// <summary>
        /// abre la conexion a la base de datos
        /// </summary>
        public static void ConexionOpen()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
        }

        /// <summary>
        /// cierra la conexion a la base de datos
        /// </summary>
        public static void ConexionClose()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();

        }

    }


}
