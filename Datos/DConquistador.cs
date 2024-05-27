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
    public class DConquistador
    {
        public static string Insertar_Conquistador(Conquistador c)
        {
            string rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("Insertar_Consquistador", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@apellido_p", c.Apellido_p);
                comando.Parameters.AddWithValue("@apellido_m", c.Apellido_m);
                comando.Parameters.Add("@edad", SqlDbType.TinyInt).Value = c.Edad;
                comando.Parameters.Add("@sexo", SqlDbType.Char).Value = c.Sexo;
                comando.Parameters.AddWithValue("@usuario", c.Usuario);
                comando.Parameters.AddWithValue("@contraseña", c.Contraseña);
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
                SqlCommand comando = new SqlCommand("existeUsuario", conn);
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
                SqlCommand comando = new SqlCommand("LogIn_Conquistador", conn);
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

        public static string Insertar_Conquistador2(Conquistador c)
        {
            string rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand("Insertar_Consquistador", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@apellido_p", c.Apellido_p);
                comando.Parameters.AddWithValue("@apellido_m", c.Apellido_m);
                comando.Parameters.Add("@edad", SqlDbType.TinyInt).Value = c.Edad;
                comando.Parameters.Add("@sexo", SqlDbType.Char).Value = c.Sexo;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                rpta = Convert.ToString(parExiste.Value);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000)
                {
                    return "YA EXISTE La CARRERA QUE INGRESO";
                }
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


    }
}
