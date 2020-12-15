using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ComiqueriaLogic.Entidades
{
    public static class ProductoDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static ProductoDAO()
        {                                              
            string connectionString = @"Server = .\ ; Database = Comiqueria  ; Trusted_Connection = true;";
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            comando.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar);
            comando.Parameters.Add("@Precio", System.Data.SqlDbType.Float);
            comando.Parameters.Add("@Stock", System.Data.SqlDbType.Int);


        }

        public static bool AgregarABaseDeDatos(Producto p)
        {
            try
            {
                conexion.Open();
                string comandoString = "INSERT INTO dbo.Productos Codigo ,Descripcion, Precio, Stock) VALUES (@codigo ,@descripcion, @precio, @stock);";

                comando.Parameters["@codigo"].Value = p.Codigo;
                comando.Parameters["@descripcion"].Value = p.Descripcion;
                comando.Parameters["@precio"].Value = p.Precio;
                comando.Parameters["@stock"].Value = p.Stock;                
                comando.CommandText = comandoString;
                comando.ExecuteNonQuery();

            }
            catch(Exception e)
            {
                throw e;
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
