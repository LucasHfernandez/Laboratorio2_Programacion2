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
            int j;
            int limite = 0;
            int suma = 0;

            for(i = 1; i < limite; i++)
            {
                for(j = 1; j <= i; j++)
                {
                    if((i % j) == 0 && j < i)
                    {
                        suma = suma + j;
                    }

                    if(i == suma)
                    {
                        break;
                    }

                    limite++;
                }

                Console.WriteLine("El 1er numero perfecto es: " + i);
            }


            Console.ReadKey();
        }
    }
}
