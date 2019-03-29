using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(double decim)
        {
            string cadena;

            do
            {
                cadena = "";
                if(decim % 2 == 0)
                {
                    cadena = cadena + "0";
                }
                else
                {
                    cadena = cadena + "1";
                }

                decim = decim / 2;

            } while (decim >= 2);


            return cadena;
        }


        public static double BinarioDecimal(string binario)
        {
            double numero = 0;
            int i = 0;

            do
            {
                if(binario[i] == '1')
                {
                    numero = numero + Math.Pow(1, i + 1);
                }

                i++;

            } while (binario[i] != '\n');


            return numero;
        }
    }
}
