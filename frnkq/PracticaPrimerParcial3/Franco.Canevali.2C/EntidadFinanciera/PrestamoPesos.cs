using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    class PrestamoPesos : Prestamo
    {
        #region Fields
        private float porcentajeInteres;
        #endregion

        #region Properties
        /// <summary>
        /// ReadOnly Expone el campo porcentajeInteres
        /// </summary>
        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Constructor publico de PrestamoPesos, establece el monto,
        /// la fechad de vencimiento y el porcentaje de interes
        /// </summary>
        /// <param name="monto">Monto del prestamo pesos</param>
        /// <param name="vencimiento">Vencimiento del PrestamoPesos</param>
        /// <param name="interes">Porcentaje de interes del PrestamoPesos</param>
        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            :base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        /// <summary>
        /// Constructor publico de PrestamoPesos, establece el monto,
        /// la fecha de vencimiento y el porcentaje de interes
        /// </summary>
        /// <param name="prestamo">Objeto del tipo Prestamo del cual se basara el PrestamoPesos</param>
        /// <param name="interes">Interes del PrestamoPesos</param>
        public PrestamoPesos(Prestamo prestamo, float interes)
            :this(prestamo.Monto, prestamo.Vencimiento, interes)
        {
            
        }
        /// <summary>
        /// Recopila datos del PrestamoPeso
        /// </summary>
        /// <returns>Una cadena con los atributos de la clase base y los propios de PrestamoPesos</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine(String.Format("Interes: {0}", this.Interes));

            return sb.ToString();
        }
        
        /// <summary>
        /// Se aplicará un incremento del 0.25% al interes original por cada dia extendido el plazo
        /// y se actualizara la fecha original del vencimiento con la nueva fecha
        /// </summary>
        /// <param name="nuevoVencimiento"></param>
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            this.Vencimiento = nuevoVencimiento;

            TimeSpan diferenciaEntreFechas = DateTime.Today - this.vencimiento;
            int cantidadDeDias = diferenciaEntreFechas.Days;

            for (int i = 0; i < cantidadDeDias; i++)
            {
                this.porcentajeInteres += (float)0.25;
            }
        }
        /// <summary>
        /// Calculara y retornara el total del prestamo
        /// (monto + monto*porcentaje)
        /// </summary>
        /// <returns></returns>
        private float CalcularInteres()
        {
            return (this.monto * (this.porcentajeInteres / 100) );
        }
        #endregion
    }
}
