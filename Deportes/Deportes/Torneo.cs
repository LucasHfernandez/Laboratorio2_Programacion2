using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes
{
    public class Torneo<T> where T : Equipo
    {
        public List<string> equipos;
        public string nombre;

        public static bool operator ==(Torneo<T> equipo, T torneo)
        {
            bool retorno = false;

            foreach(T equip in equipo.equipos)
            {

            }
        }
    }
}
