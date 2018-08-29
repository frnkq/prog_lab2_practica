using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_ej20
{
    class Peso 
    {
        public static double inDolars = 0.0569;
        public static double inEuros = 0.0777;

        private double cantidad;
        private float cotizRespectoDolar;

        public Peso()
        { }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            this.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad() => this.cantidad;


        public float GetCotizacion() => this.cotizRespectoDolar;

        /// <summary>
        /// Devuelve un objeto Peso con cantidad d
        /// </summary>
        /// <param name="d">Cantidad que se le asignara al dolar</param>
        public static implicit operator Peso(double d)
            => new Peso(d, (float)Peso.inDolars);

        /// <summary>
        /// Conversor de peso a euro. Devuelve un euro.
        /// </summary>
        /// <param name="d">Peso al que se le calculara su valor en euros</param>
        public static explicit operator Euro(Peso p)
            => new Euro(p.GetCantidad() * Peso.inEuros, (float)Euro.inDolars);

        /// <summary>
        /// Convierte peso a dolar. Devuelve un dolar.
        /// </summary>
        /// <param name="d">Peso al que se le calculara su cantidad en dolares</param>
        public static explicit operator Dolar(Peso p)
            => new Dolar(p.GetCantidad() * Peso.inDolars, (float)Peso.inDolars);


        /// <summary>
        /// Compara la cantidad de dos pesos
        /// </summary>
        /// <param name="d1">Primer peso a comparar</param>
        /// <param name="d2">Segundo peso a comparar</param>
        /// <returns>True si los dos valores son iguales, false si no lo son</returns>
        public static bool operator ==(Peso p1, Peso p2)
            => (p1.GetCantidad() == p2.GetCantidad());

        /// <summary>
        /// Compara la cantidad de dos pesos
        /// </summary>
        /// <param name="d1">Primer peso a comparar</param>
        /// <param name="d2">Segundo peso a comparar</param>
        /// <returns>True si los dos valores son distintos, false si no lo son</returns>
        public static bool operator !=(Peso p1, Peso p2)
            => !(p1 == p2);

        /// <summary>
        /// Compara la cantidad entre un peso y un euro
        /// </summary>
        /// <param name="p">Peso del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>'true' si las cantidades son iguales, 'false' si no lo son</returns>
        public static bool operator ==(Peso p, Euro e)
            => (p.GetCantidad() == e.GetCantidad());

        /// <summary>
        /// Compara la cantidad entre un peso y un euro
        /// </summary>
        /// <param name="p">Peso del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>True si son distintas, false si son iguales</returns>
        public static bool operator !=(Peso p, Euro e)
            => !(p == e);
        
        /// <summary>
        /// Compara las cantidades de un peso y de un dolar
        /// </summary>
        /// <param name="p">Peso a comparar la cantidad</param>
        /// <param name="d">Dolar a comparar la cantidad</param>
        /// <returns>True si las cantidades son iguales, false si no lo son</returns>
        public static bool operator ==(Peso p, Dolar d)
            => (p.GetCantidad() == p.GetCantidad());

        /// <summary>
        /// Compara las cantidades de un peso y de un dolar
        /// </summary>
        /// <param name="p">Peso a comparar la cantidad</param>
        /// <param name="d">Dolar a comparar la cantidad</param>
        /// <returns>True si las cantidades no son iguales, false si lo son</returns>
        public static bool operator !=(Peso p, Dolar d)
            => !(d == p);

        /// <summary>
        /// Permite la suma entre un peso y un dolar, sumando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="p">Peso del cual se obtendrá la cantidad</param>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un peso con cantidad igual a la suma de la cantidad de los parametros</returns>
        public static Peso operator +(Peso p, Dolar d)
            => new Peso(p.GetCantidad() + (d.GetCantidad() * Dolar.inPesos), (float)Peso.inDolars);

        /// <summary>
        /// Permite la resta entre un peso y un dolar, restando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="p">Peso del cual se obtendrá la cantidad</param>
        /// <param name="d">Dolar del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un peso con cantidad igual a la resta de la cantidad de los parametros</returns>
        public static Peso operator -(Peso p, Dolar d)
            => new Peso(p.GetCantidad() - (d.GetCantidad() * Dolar.inPesos), (float)Peso.inDolars);

        /// <summary>
        /// Permite la suma entre un peso y un euro, sumando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="p">Peso del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un peso con cantidad igual a la suma de la cantidad de los parametros</returns>
        public static Peso operator +(Peso p, Euro e)
            => new Peso(p.GetCantidad() + (e.GetCantidad() * Euro.inPesos), (float)Peso.inDolars);

        /// <summary>
        /// Permite la resta entre un peso y un euro, restando sus cantidades y devolviendo un dolar con ese valor
        /// </summary>
        /// <param name="p">Peso del cual se obtendrá la cantidad</param>
        /// <param name="e">Euro del cual se obtendrá la cantidad</param>
        /// <returns>Devuelve un peso con cantidad igual a la resta de la cantidad de los parametros</returns>
        public static Peso operator -(Peso p, Euro e)
            => new Peso(p.GetCantidad() - (e.GetCantidad() * Euro.inPesos), (float)Peso.inDolars);

    }
}
