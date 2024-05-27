using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using Sistema.Entidades;


namespace Sistema.Negocio
{
    public  class NTutor
    {
        public static string verificaLogin(Tutor user)
        {
            string usuario = user.Usuario;
            string clave = user.Contraseña;
            // busca si existe el usuario
            string existe = DTutor.buscarClaveAcceso(usuario);


            if (existe.Equals("1"))
            {
                // en caso de que si exista el usuario, se necesita saber si la contraseña es correcta
                string existeLogin = DTutor.loginCorrecto(usuario, clave);

                if (existeLogin.Equals("1"))
                {
                    return "correcto";
                }
                else
                {
                    return "contraseña incorrecta";

                }

            }
            else
            {
                return "No existe el usuario";
            }
        }



    }
}
