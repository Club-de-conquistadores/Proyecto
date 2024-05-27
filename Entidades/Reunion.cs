using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Reunion
    {
        private int id;
        private char puntualidad;
        private char asistencia;
        private decimal cuota;
        private string tarea;
        private string uniforme;
        private string pulcritud;

        public int Id { get => id; set => id = value; }
        public char Puntualidad { get => puntualidad; set => puntualidad = value; }
        public char Asistencia { get => asistencia; set => asistencia = value; }
        public decimal Cuota { get => cuota; set => cuota = value; }
        public string Tarea { get => tarea; set => tarea = value; }
        public string Uniforme { get => uniforme; set => uniforme = value; }
        public string Pulcritud { get => pulcritud; set => pulcritud = value; }

        public Reunion(int id, char puntualidad, char asistencia, decimal cuota, string tarea, string uniforme, string pulcritud)
        {
            Id = id;
            Puntualidad = puntualidad;
            Asistencia = asistencia;
            Cuota = cuota;
            Tarea = tarea;
            Uniforme = uniforme;
            Pulcritud = pulcritud;
        }
    }
}
