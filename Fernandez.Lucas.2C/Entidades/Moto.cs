using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private static short ruedas;
        private static int valorHora;

        public string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("**Datos de la Moto**");
            datos.AppendFormat("\n\nPatente: {0}", Patente);
            datos.AppendFormat("\nPatente: {0}", Patente);
        }

        public bool Equals(object obj)
        {
            return obj is Moto;
        }

        static Moto()
        {
            valorHora = 30;
            ruedas = 2;
        }

        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            Moto.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada, ruedas)
        {
            Moto.valorHora = valorHora;
        }


    }
}
