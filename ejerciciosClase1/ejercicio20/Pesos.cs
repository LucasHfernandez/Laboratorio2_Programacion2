using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio20
{
    class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 42.99f;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
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


        public static explicit operator Euro(Pesos p)
        {
            Dolar valorDolar = (Dolar)p;
            float cotiz;
            double resultado;

            cotiz = Pesos.GetCotizacion();
            resultado = valorDolar.GetCantidad() * cotiz;

            Euro result = new Euro(resultado);

            return result;
        }

        public static explicit operator Dolar(Pesos p)
        {
            float cotiz;
            double resultado;

            cotiz = Pesos.GetCotizacion();
            resultado = p.cantidad * cotiz;

            Dolar result = new Dolar(resultado);

            return result;
        }

        public static implicit operator Pesos(double p)
        {
            double cantidad = p * cotizRespectoDolar;
            Pesos valor = new Pesos(cantidad);

            return valor;
        }
    }
}
