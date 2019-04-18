using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

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

        public int Numero
        {
            get
            {
                return numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre): this(numero)
        {
            Nombre = nombre;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            bool valor = false;

            if(c1.Numero != c2.Numero)
            {
                valor = true;
            }

            return valor;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool valor = false;

            if (c1.Numero == c2.Numero)
            {
                valor = true;
            }

            return valor;
        }
    }
}
