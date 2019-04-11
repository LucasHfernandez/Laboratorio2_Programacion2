using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio20
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1.16f;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }


        public static explicit operator Pesos(Euro e)
        {
            Dolar valorDolar = (Dolar)e;
            float cotiz;
            double resultado;

            cotiz = Euro.GetCotizacion();
            resultado = valorDolar.GetCantidad() * cotiz;

            Pesos result = new Pesos(resultado);

            return result;
        }

        public static explicit operator Dolar(Euro e)
        {
            float cotiz;
            double resultado;

            cotiz = Euro.GetCotizacion();
            resultado = e.cantidad / cotiz;

            Dolar result = new Dolar(resultado);

            return result;
        }

        public static implicit operator Euro(double e)
        {
            double cantidad = e * cotizRespectoDolar;
            Euro valor = new Euro(cantidad);

            return valor;
        }
    }
}
