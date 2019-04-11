using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        public double Operar(Numero num1, Numero num2, string operador)
        {
            if(ValidarOperador(operador) == operador)
            {
                if(operador == "+")
                {

                }
            }
        }

        private static string ValidarOperador(string operador)
        {

            string retorno;

            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                retorno = operador;

            }
            else
            {
                retorno = "+";
            }

            return retorno;
        }
    }
}
