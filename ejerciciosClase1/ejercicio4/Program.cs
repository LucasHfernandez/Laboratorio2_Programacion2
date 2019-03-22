using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";

            int i;
            int numero = 0;
            int suma;
            int contador = 0;

            Console.WriteLine("Los numeros perfectos son: ");

            do
            {
                numero++;
                suma = 0;

                for(i = 1; i < numero; i++)
                {
                    if((numero % i) == 0)
                    {
                        suma = suma + i;
                    }
                }

                if (suma == i)
                {
                    Console.WriteLine("El numero perfecto es: {0} ", suma);
                    contador++;
                }

            } while (contador != 4);


            Console.ReadKey();
        }
    }
}
