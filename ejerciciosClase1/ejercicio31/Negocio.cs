﻿using System;
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
                if(auxiliar.Numero == c.Numero)
                {
                    valor = true;
                    break;
                }
           }

            return valor;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            bool valor = false;

            foreach (Cliente auxiliar in n.clientes)
            {
                if (auxiliar.Numero != c.Numero)
                {
                    valor = true;
                    break;
                }
            }

            return valor;
        }
    }
}
