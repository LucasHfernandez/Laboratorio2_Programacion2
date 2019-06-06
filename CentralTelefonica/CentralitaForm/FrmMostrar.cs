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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        public Centralita centralita;

        public FrmMostrar(Centralita centralita) : this()
        {
            this.centralita = centralita;
        }
    }
}
