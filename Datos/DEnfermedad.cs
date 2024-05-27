using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DEnfermedad
    {

        // procedimiento almacenado que retorne solamente el id y nombre de todas las enfermedades
        public static DataTable getEnfermedades()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {

                conn = Conexion.crearConexion();
                //conn.Open();
                SqlCommand comando = new SqlCommand("muestraEnfermedades", conn);
                comando.CommandType = CommandType.StoredProcedure;
                lector = comando.ExecuteReader();
                tabla.Load(lector);

                return tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

            }

        }


    }
}
