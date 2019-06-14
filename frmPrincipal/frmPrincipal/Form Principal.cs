using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmTestDelegado;

namespace frmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        private FormDelegado formDelegado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDelegado = new FormDelegado();
            formDelegado.MdiParent = this;
            formDelegado.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(testDelegadosToolStripMenuItem.Enabled == false)
            {
                testDelegadosToolStripMenuItem.Enabled = true;
            }
            else
            {
                testDelegadosToolStripMenuItem.Enabled = false;
            }
        }
    }
}
