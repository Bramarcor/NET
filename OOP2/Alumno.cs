using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOP2
{
    class Alumno : Persona
    {

        double nota;

        
        public Alumno(double nota, string nombre, string apellido, string materia) : base(nombre, apellido, materia)
        {
            this.nota = nota;
            // base.metodo() se utiliza para acceder a los metodos o propiedades de la clase padre
        }


        /*
        public string retornarNota()
        {
            return $"Nombre: {nombre}, Apellido: {apellido}, Materia: {materia}, Nota: {nota}";
        }
        */
        
          
       public override string ToString()
       {
           // override sobre escribe el metodo de la clase padre (en este caso el Object)
           return $"Nombre: {nombre}, Apellido: {apellido}, Materia: {materia}, Nota: {nota}";
       }
       
    }
}

