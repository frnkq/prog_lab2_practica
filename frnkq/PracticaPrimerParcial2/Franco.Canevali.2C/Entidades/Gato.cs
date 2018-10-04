using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        #region Fields
        /// <summary>
        /// Unico constructor, establece nombre y raza
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="raza">Raza</param>
        public Gato(string nombre, string raza) : base(nombre, raza) { }

        /// <summary>
        /// Retornara la informacion del gato en formato "Nombre Raza"
        /// </summary>
        /// <returns>Informacion del gato</returns>
        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        /// <summary>
        /// Utiliza el operador == verificando ademas que el objeto sea Gato y no sea null
        /// </summary>
        /// <param name="obj">Objeto a analizar</param>
        /// <returns>True en caso de que sea un gato y tenga miso nombre y raza</returns>
        public override bool Equals(object obj)
        {
            if(obj is Gato && !(obj is null))
            {
                return (this == (Gato)obj);
            }

            return false;
        }

        /// <summary>
        /// Publica informacion del gato
        /// </summary>
        /// <returns>Informacion del gato</returns>
        public override string ToString()
        {
            return this.Ficha();
        }
        
        /// <summary>
        /// Dos gatos seran iguales si comparten nombre y raza
        /// </summary>
        /// <param name="obj1">Gato a comparar con obj2</param>
        /// <param name="obj2">Gato a comparar con obj1</param>
        /// <returns></returns>
        public static bool operator ==(Gato obj1, Gato obj2)
        {
            return (String.Equals(obj1.DatosCompletos(), obj2.DatosCompletos()));
        }

        /// <summary>
        /// Dos gatos seran distintos si no comparten nombre y raza
        /// </summary>
        /// <param name="obj1">Gato a comparar con obj2</param>
        /// <param name="obj2">Gato a comparar con obj1</param>
        /// <returns></returns>
        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }
        #endregion
    }
}
