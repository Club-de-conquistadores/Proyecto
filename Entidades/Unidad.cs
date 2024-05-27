using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Unidad
    {
        private int id;
        private string nombre;
        private byte[] logotipo;
        private string lema;
        private int capitan;
        private char sexo;

        public int ID { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte[] Logotipo { get => logotipo; set => logotipo = value; }
        public string Lema { get => lema; set => lema = value; }
        public int Capitan { get => capitan; set => capitan = value; }
        public char Sexo { get => sexo; set => sexo = value; }

        public Unidad(int id, string nombre, byte[] logotipo, string lema, int capitan, char sexo)
        {
            ID = id;
            Nombre = nombre;
            Logotipo = logotipo;
            Lema = lema;
            Capitan = capitan;
            Sexo = sexo;
        }
    }
}
