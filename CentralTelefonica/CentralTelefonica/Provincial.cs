﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }

    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float resultado = 0;

            if(franjaHoraria == Franja.Franja_1)
            {
                resultado = duracion * 0.99f;
            }
            else if(franjaHoraria == Franja.Franja_2)
            {
                resultado = duracion * 1.25f;
            }
            else
            {
                resultado = duracion * 0.66f;
            }

            return resultado;
        }

        public string Mostrar()
        {
            StringBuilder llamadaProv = new StringBuilder();

            llamadaProv.AppendFormat("{0} \n\nEl costo es: {1} \nLa franja Horaria es: {2}", base.Mostrar(), CostoLlamada, franjaHoraria);

            return llamadaProv.ToString();
        }

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
        }
    }
}
