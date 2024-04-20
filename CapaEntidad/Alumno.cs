using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class Alumno : Persona
    {
        private string codigo;
        private string telefono;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public string DevolverDatosAlumno()
        {
            return "Codigo: " + this.codigo + "Apellidos: " + this.Apellidos + " Nombres : " +
                this.Nombres + " edad: " + Convert.ToString(this.Edad) + " Telefono: " + this.Telefono;
        }
    }
}