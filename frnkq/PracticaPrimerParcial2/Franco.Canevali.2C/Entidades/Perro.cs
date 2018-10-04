using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {

        #region Fields
        private int edad;
        private bool esAlfa;
        #endregion

        #region Properties
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }

            set
            {
                this.esAlfa = value;
            }
        }
        #endregion

        #region Methods
        //Constructors

        /// <summary>
        /// Constructor por defecto. Establece nombre y raza.
        /// Edad y esAlfa se inicializan en 0 y false, respectivamente.
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="raza">Raza</param>
        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this.Edad = 0;
            this.esAlfa = false;
        }

        /// <summary>
        /// Constructor completo.
        /// </summary>
        /// <param name="nombre">Nombre del perro</param>
        /// <param name="raza">Raza del perro</param>
        /// <param name="edad">Edad del perro</param>
        /// <param name="esAlfa">Es alfa</param>
        public Perro (string nombre, string raza, int edad, bool esAlfa)
            : base(nombre, raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }

        //Functionallity methods
        protected override string Ficha()
        {
            if (this.EsAlfa)
            {
                return String.Format("{0}, alfa de la manada, edad {1}",
                    base.DatosCompletos(), this.Edad);
            }
            else
            {
                return String.Format("{0} edad {1}", base.DatosCompletos(), this.Edad);
            }
        }

        //Operators
        /// <summary>
        /// Reutiliza el operador == 
        /// </summary>
        /// <param name="obj">Objeto a analizar</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(obj is Perro && !(obj is null))
            {
                return (this == (Perro)obj);
            }
            return false;
        }

        /// <summary>
        /// Publica la informacion del perro, utilizando el método Ficha();
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Ficha();
        }

        /// <summary>
        /// Perro to int, devuelve la edad del perro
        /// </summary>
        /// <param name="perro">Perro.edad</param>
        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }

        /// <summary>
        /// Dos perros serán iguales si comparten nombre, raza y edad
        /// </summary>
        /// <param name="j1">Perro a comparar con j2</param>
        /// <param name="j2">Perro a comparar con j1</param>
        /// <returns></returns>
        public static bool operator ==(Perro j1, Perro j2)
        {
            if(j1 is Perro && j2 is Perro)
            {
                if (j1.Edad == j2.Edad &&
                String.Compare(j1.DatosCompletos(), j2.DatosCompletos()) == 0)
                {
                    return true;
                }
            }
            

            return false;
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }
        #endregion



    }
}
