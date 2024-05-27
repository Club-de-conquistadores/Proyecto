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
    public class DTutor
    {
        public static string Insertar_Tutor(Tutor t)
        {
            string rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("Insertar_Tutor", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", t.Nombre);
                comando.Parameters.AddWithValue("@apellido_p", t.Apellido_p);
                comando.Parameters.AddWithValue("@apellido_m", t.Apellido_m);
                comando.Parameters.AddWithValue("@direccion", t.Direccion);
                comando.Parameters.AddWithValue("@telefono", t.Telefono);
                comando.Parameters.AddWithValue("@usuario", t.Usuario);
                comando.Parameters.AddWithValue("@contraseña", t.Contraseña);
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "NO";
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
            }
            return rpta;
        }

        public static string buscarClaveAcceso(string usuario)
        {
            SqlConnection conn = null;
            string respuesta = "";

            try
            {

                conn = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("existeTutor", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(parExiste.Value);


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


            return respuesta;
        }

        public static string loginCorrecto(string usuario, string contraseña)
        {
            SqlConnection conn = null;
            string respuesta = "";

            try
            {

                conn = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("LogIn_Tutor", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = contraseña;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(parExiste.Value);


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


            return respuesta;
        }



    }
}
