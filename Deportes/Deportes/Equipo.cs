using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public static bool operator ==(Equipo equipoUno, Equipo equipoDos)
        {
            bool retorno = false;

            if(equipoUno.nombre == equipoDos.nombre && equipoUno.fechaCreacion == equipoDos.fechaCreacion)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Equipo equipoUno, Equipo equipoDos)
        {
            return !(equipoUno == equipoDos);
        }


        public string Ficha()
        {
            StringBuilder equipo = new StringBuilder();

            equipo.AppendFormat("[{0}] fundado el [{1}]", nombre, fechaCreacion.ToString());

            return equipo.ToString();
        }
    }
}
