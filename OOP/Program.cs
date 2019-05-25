using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Juan = new Alumno("Juan");
            Alumno Fernando = new Alumno("Fernando");
            Alumno Martin = new Alumno("Martin");

            Juan.modificarDatos("Juan", 8.60);
            Fernando.modificarDatos("Fernando", 7.33);
            Martin.modificarDatos("Martin", 5.20);


            Juan.imprimirDatos();
            Fernando.imprimirDatos();
            Martin.imprimirDatos();
            Console.ReadKey();

        }
    }
}
