using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtomEuro_Click(object sender, EventArgs e)
        {                     
            if(double.TryParse(txtValor1.Text, out double cantidad))
            {
                Euro valorEuroUno = new Euro(cantidad);
                Euro valorEuroDos = new Euro(cantidad);
                Dolar valorDolarUno = new Dolar(cantidad);
                Pesos valorPesosUno = new Pesos(cantidad);

                valorDolarUno = (Dolar)valorEuroUno;
                valorPesosUno = (Pesos)valorEuroUno;

                txtEuroDolar.Text = Convert.ToString(valorDolarUno.GetCantidad());
                txtEuroEuro.Text = Convert.ToString(valorEuroDos.GetCantidad());
                txtEuroPesos.Text = Convert.ToString(valorPesosUno.GetCantidad());
            }
            
        }

        private void ButtonDolar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValor2.Text, out double cantidad))
            {
                Euro valorEuroUno = new Euro(cantidad);
                Dolar valorDolarUno = new Dolar(cantidad);
                Dolar valorDolarDos = new Dolar(cantidad);
                Dolar valorDolarTres = new Dolar(cantidad);
                Pesos valorPesosUno = new Pesos(cantidad);

                valorDolarUno = (Dolar)valorEuroUno;
                valorDolarTres = (Dolar)valorPesosUno;

                txtDolarEuro.Text = Convert.ToString(valorDolarUno.GetCantidad());
                txtDolarDolar.Text = Convert.ToString(valorDolarDos.GetCantidad());
                txtDolarPesos.Text = Convert.ToString(valorDolarTres.GetCantidad());
            }
        }

        private void ButtonPesos_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtValor3.Text, out double cantidad))
            {
                Euro valorEuroUno = new Euro(cantidad);
                Dolar valorDolarUno = new Dolar(cantidad);
                Pesos valorPesosUno = new Pesos(cantidad);
                Pesos valorPesosDos = new Pesos(cantidad);
                Pesos valorPesosTres = new Pesos(cantidad);

                valorPesosUno = (Pesos)valorEuroUno;
                valorPesosTres = (Pesos)valorDolarUno;

                txtPesosEuro.Text = Convert.ToString(valorPesosUno.GetCantidad());
                txtPesosDolar.Text = Convert.ToString(valorPesosTres.GetCantidad());
                txtPesosPesos.Text = Convert.ToString(valorPesosDos.GetCantidad());
            }
        }
    }
}
