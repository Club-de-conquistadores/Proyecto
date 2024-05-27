using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class ejemplo
    {
        Sistema.Entidades.Class1 entidad;

        public ejemplo(int a) { 
        
            Entidad = new Sistema.Entidades.Class1(a);

        }

        public Class1 Entidad { get => entidad; set => entidad = value; }
    }
}
