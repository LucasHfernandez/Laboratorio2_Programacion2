﻿using System;
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
    public partial class FrmMenu: Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public Centralita central = new Centralita();

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador nuevaLlamada = new FrmLlamador(central);
            nuevaLlamada.ShowDialog();
        }
    }
}
