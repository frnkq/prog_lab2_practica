using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Fields
        private string apellido;
        private string documento;
        private string nombre;
        #endregion

        #region Properties
        /// <summary>
        /// Read only. Devuelve el apellido.
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.Apellido;
            }
        }

        /// <summary>
        /// Get: Devuelve el documento
        /// Set: Setea el documento, si ValidarDocumentacion() devuelve true
        /// </summary>
        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if (ValidarDocumentacion(value))
                    this.documento = value;
            }
        }
        /// <summary>
        /// Read only. Devuelve el nombre.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region Methods
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        /// <summary>
        /// Recopila datos de la persona
        /// </summary>
        /// <returns>Los datos de la persona</returns>
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Nombre: {0}", this.Nombre));
            sb.AppendLine(String.Format("Apellido: {0}", this.Apellido));
            sb.AppendLine(String.Format("Documento: {0}", this.Documento));
            return sb.ToString();
        }


        /// <summary>
        /// Metodo a implementar en clases hijas.
        /// Verifica la validez de la documentacion
        /// </summary>
        /// <param name="doc">Documentacion a analizar</param>
        /// <returns>True si es una documentacion valida, false de lo contrario</returns>
        protected abstract bool ValidarDocumentacion(string doc);
        #endregion
    }
}
