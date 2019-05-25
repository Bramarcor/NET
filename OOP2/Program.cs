using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno nro1 = new Alumno(
                4.56,
                "Jose",
                "Lopez",
                "Analisis I");

            Alumno nro2 = new Alumno(
                4.56,
                "Juan",
                "Fernandez",
                "Programación");

            Alumno nro3 = new Alumno(
                4.56,
                "Martin",
                "Corrale",
                "EDI");


            Persona persona = new Persona() { nombre = "" };



            imprimirObjeto(nro1);
            imprimirObjeto(nro2);
            imprimirObjeto(nro3);

            Console.ReadKey();

        }

        static void imprimirObjeto(Alumno alumno)
        {

            Console.WriteLine(alumno);
               
    }
    }
}
