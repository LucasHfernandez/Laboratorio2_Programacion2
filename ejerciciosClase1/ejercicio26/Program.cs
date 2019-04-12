using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 26";

            List<double> numero;
            numero = new List<double>();
            int i;
            int numeroRandom;
            int cantidad = 20;
            Random nroRandom = new Random();

            Console.WriteLine("--------------------Listado de numeros-------------------------");

            for(i = 0; i < cantidad; i++)
            {
                numeroRandom = nroRandom.Next(-100, 100);

                if(numeroRandom != 0)
                {
                    numero.Add(numeroRandom);
                }
            }

            foreach(double entero in numero)
            {
                Console.WriteLine("Numero: {0} ", entero);
            }

            Console.ReadKey();

            Console.WriteLine("------------Positivos Ordenados Decreciente---------------------");

            numero.Sort(Program.ordenDesc);

            foreach (double entero in numero)
            {
                if(entero > 0)
                {
                    Console.WriteLine("Numero: {0} ", entero);
                }
            }

            Console.ReadKey();

            Console.WriteLine("------------Negativos Ordenados Creciente-----------------------");

            numero.Sort();

            foreach (double entero in numero)
            {
                if (entero < 0)
                {
                    Console.WriteLine("Numero: {0} ", entero);
                }
            }

            Console.ReadKey();
        }

        private static int ordenDesc(double num1, double num2)
        {
            return -num1.CompareTo(num2);
        }
    }
}
