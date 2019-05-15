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

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincia
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float resultado = 0;
                      
            foreach (Llamada llamada in listaDeLlamadas)
            {              
                switch(tipo)
                {
                    case TipoLlamada.Local:
                        if(llamada is Local)
                        {
                            Local local = (Local)llamada;
                            resultado = resultado + local.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if(llamada is Provincial)
                        {
                            Provincial provincia = (Provincial)llamada;
                            resultado = resultado + provincia.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            Local local = (Local)llamada;
                            resultado = resultado + local.CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            Provincial provincia = (Provincial)llamada;
                            resultado = resultado + provincia.CostoLlamada;
                        }
                        break;
                }       
            }

            return resultado;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("*************************************************");
            datos.AppendFormat("*Razon Social: {0}", razonSocial);
            datos.AppendFormat("\n*La ganancia total es: {0}", GananciasPorTotal);
            datos.AppendFormat("\n*La ganancia local es: {0}", GananciasPorLocal);
            datos.AppendFormat("\n*La ganancia provincial es: {0}", GananciasPorProvincia);
            foreach(Llamada llamada in Llamadas)
            {
                datos.AppendLine(llamada.Mostrar());
            }
            datos.AppendLine("\n\n*************************************************");

            return datos.ToString();
        }

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
