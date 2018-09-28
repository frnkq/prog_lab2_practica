using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        #region Fields
        private short anio;
        private Divisiones division;
        #endregion

        #region Properties
        /// <summary>
        /// Devuelve el año y la division en formato A°D
        /// </summary>
        public string AnioDivision
        {
            get
            {
                return String.Format("{0}º{1}", this.anio, this.division.ToString());
            }
        }
        #endregion

        #region Methods
        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        /// <summary>
        /// Recopila informacion del alumno
        /// </summary>
        /// <returns>Informacion del alumno</returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine(String.Format("Division: {0}", this.AnioDivision));
            return sb.ToString();
        }

        /// <summary>
        /// Valida que la documentacion cumpla el siguiente formato: XX-XXXX-X
        /// Siendo las x's, digitos
        /// </summary>
        /// <param name="doc">Documentacion a analizart</param>
        /// <returns>True si es una documentacion valida, false si no lo es</returns>
        protected override bool ValidarDocumentacion(string doc)
        {
            if(doc.Length == 9 && (doc.ElementAt(2) == '-' && doc.ElementAt(7) == '-'))
            {
                //removing dashes
                doc = doc.Remove(2, 1);
                doc = doc.Remove(6, 1);

                //checking everything is a number
               foreach(char c in doc)
                {
                    if (!(char.IsDigit(c)))
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }
        #endregion
    }
}
