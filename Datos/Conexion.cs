using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBD;

namespace Sistema.Datos
{
    public class Conexion
    {
        public static SqlConnection crearConexion()
        {

            //agregar la conexion
            string strConn = "Data Source=JUANTORRES;Initial Catalog=Tec2;Integrated Security=True";
            SqlConnection conn;
            try
            {
                conn = UsoBD.ConectaBD(strConn);
            }
            catch (SqlException ex)
            {

                throw ex;

            }

            return conn;
        }




    }
}
