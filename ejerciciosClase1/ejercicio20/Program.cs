using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 20";

            Pesos valorPeso1 = new Pesos(100);
            Pesos valorPeso2 = new Pesos(100);
            Pesos valorPeso3 = new Pesos(100);
            Euro valorEuro1 = new Euro(100);
            Euro valorEuro2 = new Euro(100);
            Euro valorEuro3 = new Euro(100);
            Dolar valorDolar1 = new Dolar(100);
            Dolar valorDolar2 = new Dolar(100);
            Dolar valorDolar3 = new Dolar(100);
            Dolar valorDolar4 = new Dolar(100);

            valorPeso1 = (Pesos)valorDolar1;
            valorEuro1 = (Euro)valorDolar2;
            valorDolar3 = (Dolar)valorPeso2;
            valorDolar4 = (Dolar)valorEuro2;
            valorPeso3 = (Pesos)valorEuro3;
            valorDolar4 = (Dolar)valorEuro2;


            Console.Write("El valor en peso/dolar es: {0}", valorPeso1.GetCantidad());
            Console.WriteLine(" ");
            Console.Write("El valor en euro/dolar es: {0}", valorEuro1.GetCantidad());
            Console.WriteLine(" ");
            Console.Write("El valor en dolar/peso es: {0}", valorDolar3.GetCantidad());
            Console.WriteLine(" ");
            Console.Write("El valor en dolar/euro es: {0}", valorDolar4.GetCantidad());

            Console.ReadKey();
        }
    }
}
