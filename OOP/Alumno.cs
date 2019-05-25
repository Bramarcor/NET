using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Alumno
    {
        protected string nombre;
        protected double nota;


        public Alumno(string nombre)
        {
            this.nombre = nombre;
        }


        public void imprimirDatos()
        {
            Console.WriteLine($"El nombre es: {this.nombre} y tiene una nota de: {this.nota}");
        }

        /// <summary>
        /// Modifica las propiedades del objeto Alumno
        /// </summary>
        /// <param name="nom">String</param>
        /// <param name="nota">Double</param>
        public void modificarDatos(string nom, double nota)
        {
            this.nombre = nom;
            this.nota = nota;
        }
    }
}
