using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 9";

            int numero;
            int i;
            int contador = 0;
            string datoValor;
            bool boolean;

            Console.Write("Ingrese la altura de la piramide: ");
            datoValor = Console.ReadLine();
            boolean = int.TryParse(datoValor, out numero);
            Console.WriteLine("");

            for (i = 1; i <= numero; i++)
            {
                do
                {
                    Console.Write("*");                   
                    contador++;

                } while (contador < i);

                contador = 0;
                Console.WriteLine("");
            }


            Console.ReadKey();
        }
    }
}
