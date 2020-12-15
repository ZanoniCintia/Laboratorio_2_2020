using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class ClinicaDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static ClinicaDAO()
        {
            string connectionString = @"Server = .\ ; Database = ClinicaUtn ; Trusted_Connection = true;";
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.Add("@id", System.Data.SqlDbType.Int);
            comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar);
            comando.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar);
            comando.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
            comando.Parameters.Add("@edad", System.Data.SqlDbType.Int);
            comando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar);
            comando.Parameters.Add("@cobertura", System.Data.SqlDbType.VarChar);
            comando.Parameters.Add("@especialidad", System.Data.SqlDbType.VarChar);
            comando.Parameters.Add("@observaciones", System.Data.SqlDbType.VarChar);
            comando.Parameters.Add("@fecha", System.Data.SqlDbType.VarChar);
        }

        public static bool IngresarPaciente(Pacientes p)
        {

            try
            {
                conexion.Open();
                string comandoString = "INSERT INTO dbo.Pacientes (id, nombre, apellido, sexo, edad, direccion,cobertura) VALUES (@id, @nombre, @apellido, @sexo,@edad,@direccion,@cobertura);";

                comando.Parameters["@id"].Value = p.ID;
                comando.Parameters["@nombre"].Value = p.Nombre;
                comando.Parameters["@apellido"].Value = p.Apellido;
                comando.Parameters["@sexo"].Value = p.Sexo;
                comando.Parameters["@edad"].Value = p.Edad;
                comando.Parameters["@direccion"].Value = p.Direccion;
                comando.Parameters["@cobertura"].Value = p.TipoCobertura;
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
            return true;

        }


        public static bool IngresarEspecialista(Especialistas e)
        {

            try
            {
                conexion.Open();
                string comandoString = "INSERT INTO dbo.Pacientes (id, nombre, apellido, sexo, edad, direccion,especialidad) VALUES (@id, @nombre, @apellido, @sexo,@edad,@direccion,@especialidad);";

                comando.Parameters["@id"].Value = e.ID;
                comando.Parameters["@nombre"].Value = e.Nombre;
                comando.Parameters["@apellido"].Value = e.Apellido;
                comando.Parameters["@sexo"].Value = e.Sexo;
                comando.Parameters["@edad"].Value = e.Edad;
                comando.Parameters["@direccion"].Value = e.Direccion;
                comando.Parameters["@cobertura"].Value = e.TipoEspecialidad;
                comando.CommandText = comandoString;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en base de datos", ex); ;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();

            }
            return true;

        }

        public static bool IngresarTurnos(Turnos t)
        {

            try
            {
                conexion.Open();
                string comandoString = "INSERT INTO dbo.Pacientes (id,idpaciente,idespecialista,observaciones,fecha) VALUES (@id, @idpaciente, @idespecialista, @observaciones,@fecha);";

                comando.Parameters["@id"].Value = t.IDTurno;
                comando.Parameters["@idpaciente"].Value = t.IDPaciente;
                comando.Parameters["@idespecialista"].Value = t.IDEspecialista;
                comando.Parameters["@observaciones"].Value = t.Observaciones;
                comando.Parameters["@fecha"].Value = t.Fecha;
                comando.CommandText = comandoString;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en base de datos", ex); ;
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();

            }
            return true;

        }




    } 
    
}
