using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Conquistador
    {
        private string nombre;
        private string apellido_m;
        private string apellido_p;
        private DateTime fecha_nacimiento;
        char sexo;
        int edad;
        string usuario;
        string contraseña;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_m { get => apellido_m; set => apellido_m = value; }
        public string Apellido_p { get => apellido_p; set => apellido_p = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public Conquistador (string nombre, string ape_m, string ape_p, DateTime fecha, char sexo, int edad, string usuario, string contraseña)
        {

            Nombre = nombre;
            Apellido_p = ape_p;
            Apellido_m = ape_m;
            Fecha_nacimiento = fecha;
            Sexo = sexo;
            Edad = edad;
            Usuario = usuario;
            Contraseña = contraseña;

        }

    }
}
