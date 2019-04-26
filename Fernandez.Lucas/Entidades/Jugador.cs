using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get
            {
                return altura;
            }
        }

        public float Peso
        {
            get
            {
                return peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return posicion;
            }
        }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder jugador = new StringBuilder();

            jugador.AppendFormat("***Datos Del jugador*** \n {0}", base.Mostrar());
            jugador.AppendFormat("\n Peso: {0} \n Altura: {1} \n Posicion: {2}", Peso, Altura, Posicion);

            return jugador.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float Imc = 0;

            Imc = Peso / (Altura * Altura);

            if(Imc >= 18.5 && Imc <= 25)
            {
                retorno = true;
            }

            return retorno;
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;

            if(ValidarEstadoFisico() == true && Edad <= 40)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
