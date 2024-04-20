using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Persona persona = new Persona();

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //Asignar valores a los atributos de la clase Persona 
            persona.Apellidos = txtApellidos.Text;
            persona.Nombres = txtNombres.Text;
            persona.Edad = Convert.ToInt32(txtEdad.Text);
            MessageBox.Show("Se registro correctamente el objeto Persona");
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show(persona.DevolverDatos());
        }

        private void TxtApellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
