using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Ciudad
    {
        private int id;
        private string nombre;
        private string pais;

        public int ID { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }

        public Ciudad(int id, string nombre, string pais)
        {
            ID = id;
            Nombre = nombre;
            Pais = pais;
        }
    }
}
