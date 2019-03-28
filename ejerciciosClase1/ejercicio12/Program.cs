using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";

            int numero;
            int suma = 0;
            string datoNum;
            string datoRes;
            char respuesta;
            bool boolean;

            do
            {
                Console.Clear();
                Console.Write("Ingrese un numero: ");
                datoNum = Console.ReadLine();
                boolean = int.TryParse(datoNum, out numero);
                Console.WriteLine("");
                suma = suma + numero;

                Console.WriteLine("");
                Console.WriteLine("El valor actual acumulado es: {0}", suma);
                Console.WriteLine("");

                Console.WriteLine("Desea ingresar otro numero? SI = s NO = n");
                Console.Write("Respuesta: ");
                datoRes = Console.ReadLine();
                boolean = char.TryParse(datoRes, out respuesta);

                boolean = ValidarRespuesta.ValidaS_N(respuesta);


            } while (boolean == true);

            Console.ReadKey();
        }
    }
}
