using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notafinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombreAlum, string apellidoAlum, int legajoAlum)
        {
            nombreAlum = nombre; //Corregir, la asignacion es al reves.
            apellidoAlum = apellido;
            legajoAlum = legajo;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            notaUno = nota1;
            notaDos = nota2;
        }

        public void CalcularFinal()
        {
            Random auxNota = new Random();
            if(nota1 < 4 && nota2 < 4)
            {
                notafinal = -1;
            }
            else
            {
                notafinal = auxNota.Next(4, 10);
            }
        }

        public string Mostrar()
        {
            string mostrarAlumno = "";

            if(notafinal == -1)
            {
                mostrarAlumno = "alumno desaprobado";
            }
            else
            {
                mostrarAlumno = "Nombre: " + this.nombre + "\napellido: " + this.apellido + "\nnro legajo: " + this.legajo + "\nprimera nota: " + this.nota1 + "\nsegunda nota: " + this.nota2;
            }

            return mostrarAlumno;
        }
    }
}
