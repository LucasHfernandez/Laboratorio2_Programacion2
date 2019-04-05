using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) { }

        public long Sumar(long numeroUno, long numeroDos)
        {
            long resultado = 0;

            this.cantidadSumas++;

            resultado = numeroUno + numeroDos;

            return resultado;
        }

        public string Sumar(string numeroUno, string numeroDos)
        {
            string cadena = "";

            this.cantidadSumas++;

            cadena = numeroUno + numeroDos;

            return cadena;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long resultado;

            resultado = s1.cantidadSumas + s2.cantidadSumas;

            return resultado;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool valor = false;

            if(s1.cantidadSumas == s2.cantidadSumas)
                valor = true;
           
            return valor;
        }



    }
}
