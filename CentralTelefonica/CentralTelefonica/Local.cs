using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Local : Llamada
    {
        protected float costo;

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }


        private float CalcularCosto()
        {
            float resultado = 0;

            resultado = Duracion * costo;

            return resultado;
        }

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder llamadaLocal = new StringBuilder();

            llamadaLocal.AppendFormat("{0} \n\nEl costo es: {1}", base.Mostrar(), CostoLlamada);

            return llamadaLocal.ToString();           
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
