using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Validacion
    {
       public static bool validar(int valor, int min, int max)
        {
           bool retorno = true;

            if(valor < min || valor > max)
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
