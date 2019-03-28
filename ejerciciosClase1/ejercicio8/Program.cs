using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 8";

            int respuesta;
            int año;
            int valorHora;
            int horasTrabajadas;
            int suma;
            int multiplicar;
            int multiplicarAños;
            float descuento;
            float resultado;
            string datoNombre;
            string datoAño;
            string datoValor;
            string datoHoras;
            string datoRespuesta;
            bool boolean;

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido.");
                Console.WriteLine("--------------------------");
                Console.Write("Ingrese el nombre del empleado: ");
                datoNombre = Console.ReadLine();
                Console.WriteLine(" ");
                Console.Write("Ingrese la antiguedad(años): ");
                datoAño = Console.ReadLine();
                boolean = int.TryParse(datoAño, out año);
                Console.WriteLine(" ");
                Console.Write("Ingrese el valor hora: ");
                datoValor = Console.ReadLine();
                boolean = int.TryParse(datoValor, out valorHora);
                Console.WriteLine(" ");
                Console.Write("Ingrese la cantidad de horas trabajadas: ");
                datoHoras = Console.ReadLine();
                boolean = int.TryParse(datoHoras, out horasTrabajadas);

                multiplicar = valorHora * horasTrabajadas;
                multiplicarAños = año * 150;
                suma = multiplicar + multiplicarAños;
                descuento = (suma * 13) / 100;
                resultado = suma - descuento;

                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Nombre del empleado: {0}", datoNombre);
                Console.WriteLine(" ");
                Console.WriteLine("Años en la empresa: {0}", datoAño);
                Console.WriteLine(" ");
                Console.WriteLine("El valor hora del empleado es: {0}", datoValor);
                Console.WriteLine(" ");
                Console.WriteLine("Sueldo bruto: {0}", suma);
                Console.WriteLine(" ");
                Console.WriteLine("Descuento: {0}", descuento);
                Console.WriteLine(" ");
                Console.WriteLine("Sueldo neto a cobrar: {0}", resultado);
                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine(" ");
                Console.WriteLine("Desea ingresar otro valor? SI = 1 NO = 2");
                Console.WriteLine(" ");

                Console.Write("Respuesta: ");
                datoRespuesta = Console.ReadLine();
                boolean = int.TryParse(datoRespuesta, out respuesta);

            } while (respuesta != 2);


            Console.ReadKey();

        }
    }
}
