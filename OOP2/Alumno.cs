using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOP2
{
    class Alumno : Persona
    {
        private double nota;

        private string valor;

        // Lo siguiente se llama Property
        // se usa como si fuera un metodo para cambiar los valores de las variables privadas
        // el siguiente tiene el nombre Nota y se pueden utilizar para validar los valores que se obtienen o ingresan

        public string Nota
        {
            get { return this.nota.ToString(); } // retorna el valor de la variable nota convertida en string
            set { valor = value; } // lo que se le asigne a Nota se le va a asignar a valor
        }


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

