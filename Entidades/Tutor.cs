using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Tutor
    {
        private int id;
        private string nombre;
        private string apellido_m;
        private string apellido_p;
        private string telefono;
        private string direccion;
        string usuario;
        string contraseña;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_m { get => apellido_m; set => apellido_m = value; }
        public string Apellido_p { get => apellido_p; set => apellido_p = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Tutor(int id ,string nombre, string ape_m, string ape_p, string telefono, string direccion, string usuario, string contraseña)
        {
            Id = id;
            Nombre = nombre;
            Apellido_p= ape_p;
            Apellido_m= ape_m;
            Telefono = telefono;
            Direccion = direccion;
            Usuario = usuario;
            Contraseña = contraseña;
        }

    }
}
