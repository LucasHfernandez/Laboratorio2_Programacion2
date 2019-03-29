using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            string auxAlumnoUno;
            string auxAlumnoDos;
            string auxAlumnoTres;

            Alumno alumnoUno = new Alumno("Lucas", "Fernandez", 108048);
            Alumno alumnoDos = new Alumno("Daniela", "Sturla", 108049);
            Alumno alumnoTres = new Alumno("Facundo", "Torres", 108050);

            alumnoUno.Estudiar(4, 6);
            alumnoDos.Estudiar(8, 10);
            alumnoTres.Estudiar(1, 7);

            alumnoUno.CalcularFinal();
            alumnoDos.CalcularFinal();
            alumnoTres.CalcularFinal();

            auxAlumnoUno = alumnoUno.Mostrar();
            auxAlumnoDos = alumnoUno.Mostrar();
            auxAlumnoTres = alumnoUno.Mostrar();

            Console.WriteLine("---------LISTA DE ALUMNOS---------");
            Console.WriteLine("");
            Console.WriteLine(auxAlumnoUno);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine(auxAlumnoDos);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine(auxAlumnoTres);
            Console.WriteLine("----------------------------------");

            Console.ReadKey();
        }
    }
}
