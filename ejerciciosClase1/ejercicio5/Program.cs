using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";

            int suma = 0;
            int sumaDos = 0;
            int numero;
            int i;
            int auxNum;
            string dato;
            bool boolean;

                Console.Write("Ingrese un numero: ");
                dato = Console.ReadLine();
                boolean = int.TryParse(dato, out numero);

                for(i = 1; i < numero; i++)
                {
                    suma = suma + i;
                }

                auxNum = numero + 1;
                sumaDos = numero + 1;

                while(sumaDos < suma)
                {
                    auxNum++;
                    sumaDos = sumaDos + auxNum;
                }

                Console.Write("El numero seleccionado es: " + numero);
                Console.WriteLine(" ");
                Console.Write("La suma de la izquierda es: " + suma);
                Console.WriteLine(" ");
                Console.Write("La suma de la derecha es: " + sumaDos);
                Console.WriteLine(" ");

                if(suma == sumaDos)
                {
                    Console.Write("El numero {0} pertenece a los centricos", numero);
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.Write("El numero {0} no pertenece a los centricos", numero);
                    Console.WriteLine(" ");
                }

            Console.ReadKey();
        }
    }
}
