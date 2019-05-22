using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// enumerado coleccion de datos que no se modifican y cada valor esta asociado a un numero.
enum Dias
{
    Lunes,
    Martes,
    Miercoles,
    Jueves,
    Viernes
}


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Dias variableDias = 0;

            /*
           Console.WriteLine("");
           Console.WriteLine("**********************************************");
           Console.WriteLine("---------------Practica Nro 01----------------");
           Console.WriteLine("**********************************************");


           Console.ReadKey();
           */



            /*
             * 01.- Todos los lunes, miércoles y viernes, una persona corre la misma ruta y cronometra los
             * tiempos obtenidos. Determinar el tiempo promedio que la persona tarda en recorrer la ruta
             * en una semana cualquiera.
             * 
             */
            double ingresoLunes;
            double ingresoMiercoles;
            double ingresoViernes;

            double promedioSemana;


            Console.WriteLine("\n\n***********************************************");
            Console.WriteLine("----------------Practica Nro 01----------------");
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("Ingrese el tiempo en minutos que le tomó correr el Lunes:");
            double.TryParse(Console.ReadLine(), out ingresoLunes);

            Console.WriteLine("Ingrese el tiempo en minutos que le tomó correr el Miercoles:");
            double.TryParse(Console.ReadLine(), out ingresoMiercoles);

            Console.WriteLine("Ingrese el tiempo en minutos que le tomó correr el Viernes:");
            double.TryParse(Console.ReadLine(), out ingresoViernes);

            promedioSemana = ((ingresoLunes + ingresoMiercoles + ingresoViernes) / 3);

            Console.WriteLine($"El promedio semanal que tomo realizar la misma Ruta es de: {promedioSemana} minutos");

            Console.ReadKey();

             


            // Con un enumerado se puede definir mas facilmente un switch y ayuda a la lectura del mismo.
            switch (variableDias)
            {
                case Dias.Lunes:
                    break;
                case Dias.Martes:
                    break;
                case Dias.Miercoles:
                    break;
                case Dias.Jueves:
                    break;
                case Dias.Viernes:
                    break;
                default:
                    break;
            }
        }
    }
}
