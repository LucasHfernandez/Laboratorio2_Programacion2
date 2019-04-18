using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    public enum Puesto
    {
        Caja1,
        Caja2
    }

    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return numeroActual++;
            }
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public bool Atender(Cliente cli)
        {
            bool valor = false;
            System.Threading.Thread.Sleep(3000);

            return !valor;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
    }
}
