using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            set
            {
                clientes.Enqueue(value);
            }
            get
            {
                return clientes.Dequeue();
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return clientes.Count();
            }
        }

        private Negocio()
        {
            caja = new PuestoAtencion(Puesto.Caja1);
            clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
           bool valor = false;
            
           foreach(Cliente auxiliar in n.clientes)
           {
                if(auxiliar == c)
                {
                    valor = true;
                    break;
                }
           }

            return valor;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            bool valor = true;

            foreach (Cliente auxiliar in n.clientes)
            {
                if (auxiliar == c)
                {
                    valor = false;
                    break;
                }
            }

            return valor;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool valor = false;

            if(n == c)
            {
                n.clientes.Enqueue(c);
                valor = true; 
            }

            return valor;
        }

        public static bool operator -(Negocio n, Cliente c)
        {
            bool valor = false;

            if (n == c)
            {
                n.clientes.Dequeue();
                valor = true;
            }

            return valor;
        }

        public static bool operator ~(Negocio n)
        {
            bool valor = false;

            if(n.caja.Atender(n.Cliente))
            {
                valor = true;
            }

            return valor;
        }
    }
}
