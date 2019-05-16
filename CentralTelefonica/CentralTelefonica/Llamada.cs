using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }


    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder numeros = new StringBuilder();

            numeros.AppendFormat("\nNumero de Destino: {0} \nNumero de Origen: {1} \nNumero de Duracion: {2}", NroDestino,
                                                                                                              NroOrigen,
                                                                                                              Duracion);

            return numeros.ToString();

        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int duracion = 0;

            if (llamada1.duracion > llamada2.duracion)
            {
                duracion = 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                duracion = -1;
            }

            return duracion;
        }

        public abstract float CostoLlamada
        {
            get;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;

            if(l1.Equals(l2) && l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            bool retorno = false;

            if (!(l1.Equals(l2)))
            {
                retorno = true;
            }

            return retorno;
        }


    }
}
