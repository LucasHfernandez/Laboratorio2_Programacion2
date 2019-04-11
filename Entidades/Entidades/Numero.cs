using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;

        private string setNumero
        {
            set { numero = ValidarNumero(value); }
        }

        public Numero()
        {
            setNumero = Convert.ToString(0);
        }

        public Numero(double numero)
        {
            setNumero = Convert.ToString(numero);
        }

        public Numero(string strNumero)
        {
            setNumero = strNumero;
        }

        private double ValidarNumero(string strNumero)
        {
            int i;
            int flag = 1;
            bool valor;
            double retorno = 0;


            for (i = 0; i < strNumero.Length; i++)
            {
                if (strNumero[i] < '0' || strNumero[i] > '9')
                {
                    flag = 0;
                    break;
                }
            }

            if (flag == 1)
            {
                valor = double.TryParse(strNumero, out retorno);
            }

            return retorno;
        }

        public double DecimalBinario(double numero)
        {
            string mensaje;

            if (numero > 0)
            {

            }
            else
            {
                mensaje = "Valor invalido";
            }
        }
    }
}
