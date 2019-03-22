using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 6";

            int i;
            int anioUno;
            int anioDos;
            bool boolean;
            string datoUno;
            string datoDos;

            Console.Write("Ingrese el primer año: ");
            datoUno = Console.ReadLine();
            boolean = int.TryParse(datoUno, out anioUno);
            Console.Write("Ingrese el segundo año: ");
            datoDos = Console.ReadLine();
            boolean = int.TryParse(datoDos, out anioDos);

            for(i = anioUno; i <= anioDos; i++)
            {
                if(i % 4 == 0 || i % 400 ==0)
                {
                    Console.WriteLine("Años bisiesto: {0}", i);
                    Console.WriteLine(" ");
                }
 
            }


            Console.ReadKey();
        }
    }
}
