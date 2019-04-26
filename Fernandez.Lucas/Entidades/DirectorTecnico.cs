using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            set
            {
                añosExperiencia = value;
            }
            get
            {
                return añosExperiencia;
            }
        }

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad, dni)
        {
            AñosExperiencia = añosExperiencia;
        }

        public override string Mostrar()
        {
            StringBuilder director = new StringBuilder();

            director.AppendFormat("**Director Tecnico**\n\n {0} *Años de experiencia: {1}", base.Mostrar(), AñosExperiencia);

            return director.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;

            if(Edad <= 65 && AñosExperiencia >= 2)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
