using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio20
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
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

        public static explicit operator Euro(Dolar d)
        {
            float cotiz;
            double resultado;
            
            cotiz = Euro.GetCotizacion();
            resultado = d.cantidad / cotiz;

            Euro result = new Euro(resultado);

            return result;
        }

        public static explicit operator Pesos(Dolar d)
        {
            float cotiz;
            double resultado;

            cotiz = Pesos.GetCotizacion();
            resultado = d.cantidad / cotiz;

            Pesos result = new Pesos(resultado);

            return result;
        }

        public static implicit operator Dolar(double d)
        {
            double cantidad = d * cotizRespectoDolar;
            Dolar valor = new Dolar(cantidad);

            return valor;
        }
    }
}
