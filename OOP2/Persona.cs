using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Persona
    {


        public string nombre;
        protected string apellido;
        protected string materia;

        public Persona()
        { }      

        public Persona(string nombre, string apellido, string materia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.materia = materia;
        }
        

    }
}
