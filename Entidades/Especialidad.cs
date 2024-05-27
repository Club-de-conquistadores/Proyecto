using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Especialidad
    {
        private int id;
        private string nombre;
        private string descripcion;

        public int ID { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Especialidad(int id, string nombre, string descripcion)
        {
            ID = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
