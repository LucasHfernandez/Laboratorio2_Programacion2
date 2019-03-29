using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";

            string datoDecim;
            string datoBin;
            bool valor;
            char respuesta;

            do
            {
                Console.WriteLine("Bienvenido, que desea hacer?");
                Console.WriteLine("");
                Console.WriteLine("1. convertir decimal a binario.");
                Console.WriteLine("2. convertir binario a decimal.");

            } while (respuesta != 's');


            Console.ReadKey();
        }
    }
}
