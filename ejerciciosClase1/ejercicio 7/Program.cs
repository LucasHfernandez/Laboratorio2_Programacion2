using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 7";

            int fechaActualDia;
            int dia;
            int mes;
            int anio;
            int i;
            int total = 0;
            string datoUno;
            string datoDos;
            string datoTres;
            bool boolean;

            Console.WriteLine("Ingrese el dia: ");
            datoUno = Console.ReadLine();
            boolean = int.TryParse(datoUno, out dia);
            Console.WriteLine("Ingrese el mes: ");
            datoDos = Console.ReadLine();
            boolean = int.TryParse(datoDos, out mes);
            Console.WriteLine("Ingrese el año: ");
            datoTres = Console.ReadLine();
            boolean = int.TryParse(datoTres, out anio);

            fechaActualDia = DateTime.Now.Year;

            for(i = anio; i <= fechaActualDia; i++)
            {
    
                if(i % 4 == 0 || i % 400 == 0)
                {
                    total = total + 366;
                }
                else
                {
                    total = total + 365;
                }
            }

            Console.WriteLine("La cantidad de dias vividos es: {0}", total);

            Console.ReadKey();
        }
    }
}
