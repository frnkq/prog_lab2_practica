using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        /**Fields**/
        protected Franja franjaHoraria;

        /**Properties**/
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        /**Constructors**/
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        /**Public methods**/
       
            /// <summary>
        /// Recopila información de la llamada en un string, utilizando el metodo Mostrar() de llamada y agregando los campos locales
        /// </summary>
        /// <returns>informacion de la llamada</returns>
        public string Mostrar()
        {
            StringBuilder datosProvincial = new StringBuilder();
            datosProvincial.Append(base.Mostrar());
            datosProvincial.Append(String.Format("Costo de la llamada: {0} franja horaria: {1}", this.CostoLlamada, this.franjaHoraria));

            return datosProvincial.ToString();
        }


        /**Private methods**/

        /// <summary>
        /// Calcula el costo de la llamada dependiendo su franja horaria
        /// Franja_1: 0,99
        /// Franja_2: 1.25
        /// Franja_3: 0.66
        /// </summary>
        /// <returns>Retorna el costo de la llamada, o -1 en caso de producirse un error</returns>
        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return (float)0.99 * this.duracion;
                    
                case Franja.Franja_2:
                    return (float)1.25 * this.duracion;

                case Franja.Franja_3:
                    return (float)0.66 * this.duracion;

                default:
                    return -1;
            }
        }

        //Enumerado de las distintas franjas horarias
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
