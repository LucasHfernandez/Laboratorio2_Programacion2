using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPersona
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string apellido;
        private string nombre;
        public event DelegadoString EventString;

        public string Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }
        }

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendFormat("Nombre: {0} -- Apellido: {1}", nombre, apellido);

            return mostrar.ToString();
        }

        public Persona()
        {

        }



    }
}
