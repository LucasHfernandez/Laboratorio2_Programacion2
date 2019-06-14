using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaPersona;

namespace FormPersonas
{
    public partial class FormPersona : Form
    {
        public FormPersona()
        {
            InitializeComponent();
        }

        private Persona persona;
        private event DelegadoString EventoString;

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            EventoString += NotificarCambio;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            persona.Nombre = txtNombre.ToString();
            persona.Apellido = txtApellido.ToString();

            btnCrear.Text = "Actualizar";

            MessageBox.Show(persona.Mostrar());

            NotificarCambio("El usuario se ha creado! :D");
            
        }
    }
}
