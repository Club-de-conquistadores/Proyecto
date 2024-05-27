using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Club
    {
        private int id;
        private string nombre;
        private string lema;
        private byte[] logo;
        private string direccion;
        private string telefono;

        public int ID { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Lema { get => lema; set => lema = value; }
        public byte[] Logo { get => logo; set => logo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public Club(int id, string nombre, string lema, byte[] logo, string direccion, string telefono)
        {
            ID = id;
            Nombre = nombre;
            Lema = lema;
            Logo = logo;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
