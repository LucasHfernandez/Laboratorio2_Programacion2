using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralTelefonica;

namespace CentralitaForm
{
    public partial class FrmLlamador : Form
    {
        public FrmLlamador()
        {
            InitializeComponent();
        }

        public Centralita centralita;

        public FrmLlamador(Centralita centralita) : this()
        {
            this.centralita = centralita;
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }

        public Centralita central
        {
            get
            {
                return centralita;
            }
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtNroDestino.Text != " ")
            {
                if(txtNroDestino.Text[0] == '#')
                {
                    cmbFranja.Enabled = true;
                }
                else
                {
                    cmbFranja.Enabled = false;
                }
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = string.Empty;
        }
    }
}
