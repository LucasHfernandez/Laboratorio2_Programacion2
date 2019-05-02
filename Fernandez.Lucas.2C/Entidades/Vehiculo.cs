using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            set
            {
                if(patente.Length == 6)
                    patente = value;
            }

            get
            {
                return patente;
            }
        }

        public Vehiculo(string patente)
        {
            this.patente = patente;
            ingreso = DateTime.Now.AddHours(-3);
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            StringBuilder patente = new StringBuilder();

            patente.AppendFormat("Patente: {0}", this.patente);

            return patente.ToString();
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("**Datos del Vehiculo**");
            datos.AppendLine("\n\n" + ToString());
            datos.AppendFormat("\nIngreso: {0}", ingreso);

            return datos.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool resultado = false;

            if(v1.Equals(v2) && v1.patente == v2.patente)
            {
                resultado = true;
            }

            return resultado;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            bool resultado = false;

            if (!(v1.Equals(v2) && v1.patente == v2.patente))
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
