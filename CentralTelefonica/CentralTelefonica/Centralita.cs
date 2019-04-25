using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        /*public float GananciasPorLocal
        {
            get
            {

            }
        }*/

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
        {
            razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float resultado = 0;
            
            if(tipo == TipoLlamada.Local)
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if(llamada is Local)
                    {
                        Local local = (Local)llamada;
                        resultado = resultado + local.CostoLlamada;
                    }
                }
            }
        }
    }
}
