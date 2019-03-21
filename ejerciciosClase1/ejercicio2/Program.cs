using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";

            int numero;
            int cuadrado;
            int cubo;
            string dato;
            bool bolear;

            Console.Write("Bienvenido");
            Console.WriteLine(" ");
            Console.Write("Ingrese un numero: ");
            dato = Console.ReadLine();
            bolear = int.TryParse(dato, out numero);

            while(numero < 0)
            {
                Console.WriteLine("ERROR! Reingresar numero: ");
                dato = Console.ReadLine();
                bolear = int.TryParse(dato, out numero);
            }

            cuadrado = (int)Math.Pow(numero, 2);
            cubo = (int)Math.Pow(numero, 3);

            Console.WriteLine(" ");
            Console.WriteLine("El numero es: " + numero);
            Console.WriteLine(" ");
            Console.WriteLine("El cuadrado es: " + cuadrado);
            Console.WriteLine(" ");
            Console.WriteLine("El cubo es: " + cubo);
            Console.WriteLine(" ");

            Console.ReadKey();
        }
    }
}
