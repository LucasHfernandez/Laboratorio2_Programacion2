using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";

            int numero;
            int i;
            int suma = 0;
            int minimo = -100;
            int maximo = 100;
            int auxMin = int.MaxValue;
            int auxMax = int.MinValue;
            float promedio;
            int cantidad = 10;
            bool boolean;
            string dato;

            for(i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el numero {0}: ", i);
                dato = Console.ReadLine();
                boolean = int.TryParse(dato, out numero);
                Console.WriteLine("");

                boolean = Validacion.validar(numero, minimo, maximo);

                if(boolean == true)
                {
                    suma = suma + numero;

                    if (numero > auxMax)
                    {
                        auxMax = numero;
                    }

                    if (numero < auxMin)
                    {
                        auxMin = numero;
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("El dato ingresado no es valido, no se tomara en cuenta");
                    Console.WriteLine("");
                }
            }

            promedio = suma / i;

            Console.WriteLine("");
            Console.WriteLine("El valor minimo es: {0}", auxMin);
            Console.WriteLine("");
            Console.WriteLine("El valor maximo es: {0}", auxMax);
            Console.WriteLine("");
            Console.WriteLine("El promedio es: {0}", promedio);


            Console.ReadKey();
        }
    }
}
