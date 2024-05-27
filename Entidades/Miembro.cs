using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Miembro
    {
        private string nombre;
        private string apellido_m;
        private string apellido_p;
        char sexo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_m { get => apellido_m; set => apellido_m = value; }
        public string Apellido_p { get => apellido_p; set => apellido_p = value; }
        public char Sexo { get => sexo; set => sexo = value; }

        public Miembro(string nombre, string ape_m, string ape_p, char sexo)
        {

            Nombre = nombre;
            Apellido_p = ape_p;
            Apellido_m = ape_m;
            Sexo = sexo;

        }



    }
}
