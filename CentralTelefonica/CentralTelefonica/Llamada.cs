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


    public class Llamada
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

        public string Mostrar()
        {
            StringBuilder numeros = new StringBuilder();

            numeros.AppendFormat("\nNumero de Destino: {0} \nNumero de Origen: {1} \nNumero de Duracion: {2}",NroDestino, 
                                                                                                              NroOrigen, 
                                                                                                              Duracion);

            return numeros.ToString();

        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int duracion = 0;

            if(llamada1.duracion > llamada2.duracion)
            {
                duracion = 1;
            }
            else if(llamada1.duracion < llamada2.duracion)
            {
                duracion = -1;
            }

            return duracion;
        }
    }
}
