using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Instructor
    {
        private int id;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string telefono;
        private int especialidadID;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int EspecialidadID { get => especialidadID; set => especialidadID = value; }

        public Instructor(int id, string nombre, string apellidoPaterno, string apellidoMaterno, string telefono, int especialidadID)
        {
            Id = id;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Telefono = telefono;
            EspecialidadID = especialidadID;
        }
    }
}
