using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        #region Fields
        protected float monto;
        protected DateTime vencimiento;
        #endregion

        #region Properties
        public float Monto
        {
            get
            {
                return this.monto;
            }
        }
        /// <summary>
        /// Get: Devuelve la fecha de vencimiento
        /// Set: Verifica que la nueva fecha de vencimiento sea posterior a la DateTime.Today,
        /// caso contrario, la fecha de vencimiento se seteara en DateTime.Today
        /// </summary>
        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if (this.vencimiento.Date > value.Date)
                    this.vencimiento = DateTime.Today;
                else
                    this.vencimiento = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Unico constructor de prestamo. 
        /// Establece el monto y el vencimiento, utilizando la propiedad Vencimiento
        /// </summary>
        /// <param name="monto">Monto del prestamo</param>
        /// <param name="vencimiento">Fecha de vencimiento del prestamo</param>
        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.Vencimiento = vencimiento;
        }

        /// <summary>
        /// Recopila los datos del prestamo
        /// </summary>
        /// <returns>Una cadena con los datos del prestamo</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Prestamo");
            sb.AppendLine("Monto: " + this.monto);
            sb.AppendLine("Fecha de vencimiento: " + this.Vencimiento.Date.ToString());

            return sb.ToString();
        }


        /// <summary>
        /// Extiende el plazo del vencimiento
        /// </summary>
        /// <param name="nuevoVencimiento">nuevo vencimiento</param>
        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);


        /// <summary>
        /// Recibe dos prestamos y retorna un entero basado en sus fechas de vencimiento
        /// </summary>
        /// <param name="p1">Prestamo 1 a comparar con p2</param>
        /// <param name="p2">Prestamo 2 a comparar con p1</param>
        /// <returns>
        /// 0 si las fechas de vencimiento son iguales
        /// 1 si la fechad de vencimiento del primer producto es posterior a la del segundo
        /// -1 si la fecha de vencimiento del primer producto es anterior a la del segundo
        /// </returns>
        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            if (p1.Vencimiento == p2.Vencimiento)
                return 0;
            else if (p1.Vencimiento > p2.Vencimiento)
                return 1;
            else
                return -1;
        }
        #endregion
    }
}
