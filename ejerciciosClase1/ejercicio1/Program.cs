using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            Console.WriteLine("Bienvenido");

            int i;
            int num;
            int suma = 0;
            int promedio;
            bool mensaje;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            string numero;

            for(i=0;i<5;i++)
            {
                Console.Write("Ingrese el numero {0}: ", i+1);
                numero = Console.ReadLine();
                mensaje = int.TryParse(numero, out num);

                if(num > maximo)
                {
                    maximo = num;
                }

                if (num < minimo)
                {
                    minimo = num;
                }

                suma = suma + num;
            }

            promedio = suma / i;
            Console.Clear();
            Console.WriteLine("El maximo de los numeros ingresados es: " + maximo);
            Console.WriteLine("El minimo de los numeros ingresados es: " + minimo);
            Console.WriteLine("El promedio es: " + promedio);

            Console.ReadKey();
        }
    }
}

//federicordavila@gmail.com
// github: fededavila1984/_utn_prog_y_lab_II
// *visual studio Express(2017 en adelante) *SQL Express