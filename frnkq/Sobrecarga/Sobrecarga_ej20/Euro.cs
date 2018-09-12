using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_ej20
{
    public class Euro {
        public static double inDolars = 1.3642;
        public static double inPesos = 23.94;

        private double cantidad;
        private float cotizRespectoDolar;

        public Euro()
        { }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            this.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }

        /// <summary>
        /// Devuelve un objeto Dolar con cantidad d
        /// </summary>
        /// <param name="d">Cantidad que se le asignara al dolar</param>
        public static implicit operator Euro(double d)
        {
           return new Euro(d, (float)Euro.inDolars);
        }

        /// <summary>
        /// Conversor de dolar a euro. Devuelve un euro.
        /// </summary>
        /// <param name="d">Dolar al que se le calculara su valor en euros</param>
        public static explicit operator Dolar(Euro e)
            => new Dolar(e.GetCantidad() * Euro.inDolars, 1);

        /// <summary>
        /// Convierte dolar a peso. Devuelve un peso.
        /// </summary>
        /// <param name="d">Dolar al que se le calculara su cantidad en pesos</param>
        public static explicit operator Peso(Euro e)
            => new Peso(e.GetCantidad() * Euro.inPesos, (float)Peso.inDolars);


        /// <summary>
        /// Compara la cantidad de dos dolares
        /// </summary>
        /// <param name="d1">Primer dolar a comparar</param>
        /// <param name="d2">Segundo dolar a comparar</param>
        /// <returns>True si los dos valores son iguales, false si no lo son</returns>
        public static bool operator ==(Euro e1, Euro e2)
            => (e1.GetCantidad() == e2.GetCantidad());

        /// <summary>
        /// Compara la cantidad de dos dolares
        /// </summary>
        /// <param name="d1">Primer dolar a comparar</param>
        /// <param name="d2">Segundo dolar a comparar</param>
        /// <returns>True si los dos valores son distintos, false si no lo son</returns>
        public static bool operator !=(Euro e1, Euro e2)
            => !(e1 == e2);

        /// <summary>
        /// Compara la cantidad entre un dolar y un euro
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>'true' si las cantidades son iguales, 'false' si no lo son</returns>
        public static bool operator ==(Euro e, Dolar d)
            => (d.GetCantidad() == e.GetCantidad());

        /// <summary>
        /// Compara la cantidad entre un dolar y un euro
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>True si son distintas, false si son iguales</returns>
        public static bool operator !=(Euro e, Dolar d)
            => !(d == e);

        /// <summary>
        /// Compara las cantidades de un dolar y de un peso
        /// </summary>
        /// <param name="d">Dolar a comparar la cantidad</param>
        /// <param name="p">Peso a comparar la cantidad</param>
        /// <returns>True si las cantidades son iguales, false si no lo son</returns>
        public static bool operator ==(Euro e, Peso p)
            => (e.GetCantidad() == p.GetCantidad());

        /// <summary>
        /// Compara las cantidades de un dolar y de un peso
        /// </summary>
        /// <param name="d">Dolar a comparar la cantidad</param>
        /// <param name="p">Peso a comparar la cantidad</param>
        /// <returns>True si las cantidades no son iguales, false si lo son</returns>
        public static bool operator !=(Euro e, Peso p)
            => !(e == p);

        /// <summary>
        /// Permite la suma entre un dolar y un peso, sumando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="p">Peso del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un dolar con cantidad igual a la suma de la cantidad de los parametros</returns>
        public static Euro operator +(Euro e, Peso p)
            => new Euro(e.GetCantidad() + (p.GetCantidad() * Peso.inDolars), (float)Euro.inDolars);

        /// <summary>
        /// Permite la resta entre un dolar y un peso, restando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="p">Peso del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un dolar con cantidad igual a la resta de la cantidad de los parametros</returns>
        public static Euro operator -(Euro e, Peso p)
            => new Euro(e.GetCantidad() - (p.GetCantidad() * Peso.inDolars), 1);

        /// <summary>
        /// Permite la suma entre un dolar y un euro, sumando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un dolar con cantidad igual a la suma de la cantidad de los parametros</returns>
        public static Euro operator +(Dolar d, Euro e)
            => new Euro(d.GetCantidad() + (e.GetCantidad() * Euro.inDolars), (float)Euro.inDolars);

        /// <summary>
        /// Permite la resta entre un dolar y un euro, restando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un dolar con cantidad igual a la resta de la cantidad de los parametros</returns>
        public static Euro operator -(Dolar d, Euro e)
            => new Euro(d.GetCantidad() - (e.GetCantidad() * Euro.inDolars), (float)Euro.inDolars);
    }
}
