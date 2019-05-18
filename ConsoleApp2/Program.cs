using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double centigrados;
            double fahrenheit;
            string ingresoConsola;
            int longitudSerieFibo = 0;
            Console.WriteLine("Escribe una temperatura °C: ");
            // se ingresa un string y lo convierte si no se puede convertir tira error
            //centigrados = Convert.ToDouble(Console.ReadLine());

            // se ingresa un string y lo convierte con tryParse
            // si lo puede concertir modifica la variable centrigrados
            // si no lo puede convertir en centigrados retornará valor 0.
            ingresoConsola = Console.ReadLine();
            double.TryParse(ingresoConsola, out centigrados);


            fahrenheit = gradosCaF(centigrados);

            Console.WriteLine($"Los grados {centigrados} °C son en Fahrenheit {fahrenheit} °F");
            Console.WriteLine(9.0/5); // Test, si no esta 1 numero en double, trunca los decimales.
            

            Console.WriteLine("Ingresa la longitud de la serie de Fibonaci:");
            ingresoConsola = Console.ReadLine();
            int.TryParse(ingresoConsola, out longitudSerieFibo);
            serieFibo(longitudSerieFibo);
            Console.ReadKey();
        }

        private static double gradosCaF(double centi)
        {
            return (((9.0 / 5.0) * centi) + 32);
        }

        private static void serieFibo(int cantidadSumas)
        {
            int primerTermino = 1;
            int segundoTermino = 1;
            int resultado = 0;

            for (int i = 0; i <= cantidadSumas; i++)
            {
                resultado = primerTermino + segundoTermino;
                Console.WriteLine($"{primerTermino} + {segundoTermino} = {resultado}");
                primerTermino = segundoTermino;
                segundoTermino = resultado;
            }
        }

    }
}
