using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool validar = false;

            if(c == 's' || c == 'S')
            {
                validar = true;
            }

            return validar;
        }
    }
}
