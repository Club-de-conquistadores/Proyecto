using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Clase
    {
        private int id;
        private string nombre;
        private string color;
        private byte[] logotipo;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Color { get => color; set => color = value; }
        public byte[] Logotipo { get => logotipo; set => logotipo = value; }

        public Clase(int id, string nombre, string color, byte[] logotipo)
        {
            Id = id;
            Nombre = nombre;
            Color = color;
            Logotipo = logotipo;
        }
    }
}
