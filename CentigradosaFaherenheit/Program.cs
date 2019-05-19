using System;

namespace CentigradosaFaherenheit
{
    class Program
    {
        static void Main(string[] args)
        {


            string ingresoConsola;
            int longitudSerieFibo = 0;


            Console.WriteLine("Ingresa la longitud de la serie de Fibonacci:");
            ingresoConsola = Console.ReadLine();
            int.TryParse(ingresoConsola, out longitudSerieFibo);
            serieFibo(longitudSerieFibo);

            Console.ReadKey();
        }

        private static void serieFibo(int cantidadSumas)
        {
            ulong primerTermino = 1;
            ulong segundoTermino = 1;
            ulong resultado = 0;

            for (int i = 0; i <= (cantidadSumas - 1); i++)
            {
                resultado = primerTermino + segundoTermino;
                Console.WriteLine($"{primerTermino} + {segundoTermino} = {resultado}");
                primerTermino = segundoTermino;
                segundoTermino = resultado;

            }
        }
    }
}
