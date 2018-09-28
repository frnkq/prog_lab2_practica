using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        #region Fields
        private DateTime fechaIngreso;
        #endregion

        #region Properties
        /// <summary>
        /// Read only. Devuelve la cantidad de dias que pasaron entre 
        /// fechaIngreso y DateTime.Today
        /// </summary>
        public int Antiguedad
        {
            get
            {
                return (int)((DateTime.Today - this.fechaIngreso).TotalDays);
            }
        }
        #endregion

        #region Methods
        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        /// <summary>
        /// Recopila los datos del profesor, con la adicion de la propiedad Antiguedad
        /// </summary>
        /// <returns>Datos del profesor</returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine(String.Format("Fecha de ingreso: {0} ({1} dias de antiguedad",
                                        this.fechaIngreso.ToString(), this.Antiguedad));
            return sb.ToString();
        }

        /// <summary>
        /// Valida que la documentacion sea valida
        /// </summary>
        /// <param name="doc">Documentacion a analizar</param>
        /// <returns>True si es una documentacion valida</returns>
        protected override bool ValidarDocumentacion(string doc)
        {
            return true;
        }
        #endregion
    }
}
