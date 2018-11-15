using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string fotoPersona;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string FotoAlumno
        {
            get
            {
                return this.fotoPersona;
            }
            set
            {
                this.fotoPersona = value;
            }
        }

        public Persona(string nombre, string apellido, int dni, string ruta)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.dni = dni;
            this.fotoPersona = ruta;
        }
    }
}
