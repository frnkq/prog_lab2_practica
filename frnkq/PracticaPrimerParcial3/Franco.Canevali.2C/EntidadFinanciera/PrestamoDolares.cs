using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolares : Prestamo
    {
        #region Fields
        private PeriodicidadDePagos periodicidad;
        #endregion

        #region Properties
        /// <summary>
        /// Readonly. Retornara el interes calculado con la propiedad Periodicidad.
        /// </summary>
        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        /// <summary>
        /// Readonly. Retorna la periodicidad del objeto PrestamoDolares
        /// </summary>
        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Constructor publico de PrestamoDolares
        /// Establece el monto, vencimiento y periodicidad
        /// </summary>
        /// <param name="monto">Monto del PrestamoDolares</param>
        /// <param name="vencimiento">Vencimiento del PrestamoDolares</param>
        /// <param name="periodicidad">Periodicidad del PrestamoDolares</param>
        public PrestamoDolares(float monto, DateTime vencimiento,
            PeriodicidadDePagos periodicidad)
            :base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }
        /// <summary>
        /// Constructor publico de PrestamoDolares, establece el monto,
        /// la fecha de vencimiento y la periodicidad
        /// </summary>
        /// <param name="prestamo">Objeto del tipo Prestamo del cual se basara el PrestamoDolares</param>
        /// <param name="interes">periodicidad del PrestamoDolares</param>
        public PrestamoDolares(Prestamo prestamo, PeriodicidadDePagos periodicidad)
            : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)

        {

        }

        /// <summary>
        /// Recopila datos del PrestamoDolar
        /// </summary>
        /// <returns>Una cadena con los atributos de la clase base y los propios de PrestamoDolar</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Tipo: dolares");
            sb.AppendLine(String.Format("Interes: {0}", this.Interes));
            sb.AppendLine("---------");
            return sb.ToString();
        }

        /// <summary>
        /// El porcentaje de interes esta dado por la periodicidad del pago
        /// Periodicidad.Mensual: 25
        /// Periodicidad.Bimestral: 35
        /// Periodicidad.Trimestral: 40
        /// </summary>
        /// <returns>El interes total</returns>
        private float CalcularInteres()
        {
            switch (this.periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    return (float)(this.monto * 0.25);

                case PeriodicidadDePagos.Bimestral:
                    return (float)(this.monto * 0.35);

                case PeriodicidadDePagos.Trimestral:
                    return (float)(this.monto * 0.40);

                default:
                    return this.monto;

            }
        }


        /// <summary>
        /// Se aplicará un incremento de 2.5 dolares al monto original por cada dia extendido el plazo
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
                this.monto += (float)2.5;
            }
        }
        #endregion
    }
}
