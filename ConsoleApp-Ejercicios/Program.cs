using System;

namespace ConsoleApp_Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            primerEjercicio();

            

            /*
            Console.WriteLine("");
            Console.WriteLine("**********************************************");
            Console.WriteLine("---------------Practica Nro 01----------------");
            Console.WriteLine("**********************************************");


            Console.ReadKey();
            */
        }

        static void primerEjercicio()
        {
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
            double.TryParse(Console.ReadLine() , out ingresoLunes);

            Console.WriteLine("Ingrese el tiempo en minutos que le tomó correr el Miercoles:");
            double.TryParse(Console.ReadLine(), out ingresoMiercoles);

            Console.WriteLine("Ingrese el tiempo en minutos que le tomó correr el Viernes:");
            double.TryParse(Console.ReadLine(), out ingresoViernes);

            promedioSemana = ((ingresoLunes + ingresoMiercoles + ingresoViernes) / 3) ;

            Console.WriteLine($"El promedio semanal que tomo realizar la misma Ruta es de: {promedioSemana} minutos");

            Console.ReadKey();

        }




    }
}
