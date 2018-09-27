using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        /**Fields**/
        protected float costo;

        /**Properties**/
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        
        /**Constructors**/
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }


        /**Public methods**/


        /// <summary>
        /// Recopila información de la llamada en un string, utilizando el metodo Mostrar() de llamada y agregando los campos locales
        /// </summary>
        /// <returns>informacion de la llamada</returns>
        public string Mostrar()
        {
            StringBuilder datosLocal = new StringBuilder();
            datosLocal.Append(base.Mostrar());
            datosLocal.AppendLine(String.Format("Costo de la llamada: {0}", this.CostoLlamada));

            return datosLocal.ToString();
        }

        /**Private methods**/

        /// <summary>
        /// Calcula el costo de la llamada multiplicando la duración por el costo de la misma
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }
    }
}
