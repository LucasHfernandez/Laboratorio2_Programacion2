using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";

            int numero;
            int i;
            int j;
            int contador = 0;
            string dato;
            bool bolear;

                Console.Write("Bienvenido");
                Console.WriteLine(" ");
                Console.Write("Ingrese un numero: ");
                dato = Console.ReadLine();
                bolear = int.TryParse(dato, out numero);

                for(i = 1; i <= numero; i++)
                {
                    for(j = 1; j <= i; j++)
                    {
                       if((i % j) == 0 && contador < 3)
                       {
                        contador++;
                       }
                    }

                    if(contador == 2)
                    {
                        Console.WriteLine("Numero primo: {0}", i);
                    }

                    contador = 0;

                }

            Console.ReadKey();
        }
    }
}
