using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 19";

            Sumador sumador = new Sumador(1);
            Sumador sumadorDos = new Sumador(3);

            long numeroUno = 5;
            long numeroDos = 7;
            long resultado;
            long cantSuma;
            string numero1 = "20";
            string numero2 = "19";
            string cadena;
            bool valor;

            resultado = sumador.Sumar(numeroUno, numeroDos);
            cadena = sumador.Sumar(numero1, numero2);
            cantSuma = sumador + sumadorDos;
            valor = sumador | sumadorDos;

            Console.WriteLine("La suma es: {0}", resultado);
            Console.WriteLine("El numero es: {0}", cadena);
            Console.WriteLine("La suma de los sumadores es: {0}", cantSuma);
           
            if(valor == true)
            {
                Console.WriteLine("Los sumadores son iguales");
            }
            else
            {
                Console.WriteLine("Los sumadores no son iguales");
            }

            Console.ReadKey();
        }
    }
}
