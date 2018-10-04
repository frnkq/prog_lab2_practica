using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        protected abstract string Ficha();

        /// <summary>
        /// Retornara el nombre y la raza con el formato "Nombre Raza"
        /// </summary>
        /// <returns>El nombre y la raza en formato "Nombre Raza"</returns>
        protected virtual string DatosCompletos()
        {
            return String.Format("{0} {1}", this.Nombre, this.Raza);
        }

    }
}
