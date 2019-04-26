using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class VistaForm : Form
    {
        private DirectorTecnico dt;
        public VistaForm()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)nUpDownEdad.Value, (int)nUpDownDni.Value, (int)nUpDownExp.Value);
            MessageBox.Show("El DT se creo", "DT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
