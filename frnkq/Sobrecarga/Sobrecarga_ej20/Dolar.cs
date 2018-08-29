using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_ej20
{
    class Dolar
    {
        public static double inPesos = 17.55;
        public static double inEuros = 0.7330;

        private double cantidad;
        private float cotizRespectoDolar;

        public Dolar()
        { }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            this.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad() => this.cantidad;
        public float GetCotizacion() => this.cotizRespectoDolar;

        /// <summary>
        /// Devuelve un objeto Dolar con cantidad d
        /// </summary>
        /// <param name="d">Cantidad que se le asignara al dolar</param>
        public static implicit operator Dolar(double d) 
            => new Dolar(d, 1);

        /// <summary>
        /// Conversor de dolar a euro. Devuelve un euro.
        /// </summary>
        /// <param name="d">Dolar al que se le calculara su valor en euros</param>
        public static explicit operator Euro(Dolar d)
            => new Euro(d.GetCantidad() * Dolar.inEuros, (float)Euro.inDolars);

        /// <summary>
        /// Convierte dolar a peso. Devuelve un peso.
        /// </summary>
        /// <param name="d">Dolar al que se le calculara su cantidad en pesos</param>
        public static explicit operator Peso(Dolar d)
            => new Peso(d.GetCantidad() * Dolar.inPesos, (float)Peso.inDolars);


        /// <summary>
        /// Compara la cantidad de dos dolares
        /// </summary>
        /// <param name="d1">Primer dolar a comparar</param>
        /// <param name="d2">Segundo dolar a comparar</param>
        /// <returns>True si los dos valores son iguales, false si no lo son</returns>
        public static bool operator ==(Dolar d1, Dolar d2) 
            => (d1.GetCantidad() == d2.GetCantidad());

        /// <summary>
        /// Compara la cantidad de dos dolares
        /// </summary>
        /// <param name="d1">Primer dolar a comparar</param>
        /// <param name="d2">Segundo dolar a comparar</param>
        /// <returns>True si los dos valores son distintos, false si no lo son</returns>
        public static bool operator !=(Dolar d1, Dolar d2) 
            => !(d1 == d2);

        /// <summary>
        /// Compara la cantidad entre un dolar y un euro
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>'true' si las cantidades son iguales, 'false' si no lo son</returns>
        public static bool operator ==(Dolar d, Euro e)
            => (d.GetCantidad() == e.GetCantidad());

        /// <summary>
        /// Compara la cantidad entre un dolar y un euro
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>True si son distintas, false si son iguales</returns>
        public static bool operator !=(Dolar d, Euro e)
            => !(d == e);

        /// <summary>
        /// Compara las cantidades de un dolar y de un peso
        /// </summary>
        /// <param name="d">Dolar a comparar la cantidad</param>
        /// <param name="p">Peso a comparar la cantidad</param>
        /// <returns>True si las cantidades son iguales, false si no lo son</returns>
        public static bool operator==(Dolar d, Peso p)
            => (p.GetCantidad() == p.GetCantidad());
        
        /// <summary>
        /// Compara las cantidades de un dolar y de un peso
        /// </summary>
        /// <param name="d">Dolar a comparar la cantidad</param>
        /// <param name="p">Peso a comparar la cantidad</param>
        /// <returns>True si las cantidades no son iguales, false si lo son</returns>
        public static bool operator !=(Dolar d, Peso p)
            => !(d == p);

        /// <summary>
        /// Permite la suma entre un dolar y un peso, sumando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="p">Peso del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un dolar con cantidad igual a la suma de la cantidad de los parametros</returns>
        public static Dolar operator +(Dolar d, Peso p) 
            => new Dolar(d.GetCantidad() + (p.GetCantidad() * Peso.inDolars), 1);

        /// <summary>
        /// Permite la resta entre un dolar y un peso, restando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="p">Peso del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un dolar con cantidad igual a la resta de la cantidad de los parametros</returns>
        public static Dolar operator -(Dolar d, Peso p)
            => new Dolar(d.GetCantidad() - (p.GetCantidad() * Peso.inDolars), 1);

        /// <summary>
        /// Permite la suma entre un dolar y un euro, sumando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un dolar con cantidad igual a la suma de la cantidad de los parametros</returns>
        public static Dolar operator +(Dolar d, Euro e)
            => new Dolar(d.GetCantidad() + (e.GetCantidad() * Euro.inDolars), 1);

        /// <summary>
        /// Permite la resta entre un dolar y un euro, restando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un dolar con cantidad igual a la resta de la cantidad de los parametros</returns>
        public static Dolar operator -(Dolar d, Euro e) 
            => new Dolar(d.GetCantidad() - (e.GetCantidad() * Euro.inDolars), 1);

    }
}
