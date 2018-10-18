using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        #region Fields
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Properties
        /// <summary>
        /// Read only. Retorna la duracion de la llamada.
        /// </summary>
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        /// <summary>
        /// Read only. Retorna el numero de destino de la llamada.
        /// </summary>
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        /// <summary>
        /// Read only. Retorna el numero de origen de la llamada.
        /// </summary>
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        /// <summary>
        /// Abstract. Read only.
        /// </summary>
        public abstract float CostoLlamada { get;  }
        #endregion

        #region Constructors
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Methods
        protected virtual string Mostrar()
        {

            StringBuilder datosLlamada = new StringBuilder();
            datosLlamada.AppendLine("--------------");
            datosLlamada.AppendLine("Llamada");
            datosLlamada.AppendLine(String.Format("Duracion: {0}", this.Duracion));
            datosLlamada.AppendLine(String.Format("Numero de origen: {0}", this.NroOrigen));
            datosLlamada.AppendLine(String.Format("Numero de destino: {0}", this.NroDestino));

            return datosLlamada.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
                return 1;
            else if (llamada1.Duracion < llamada2.Duracion)
                return -1;

            return 0;
        }
        #endregion

        #region Operators
        /// <summary>
        /// Compara la igualdad de dos llamadas, segun el tipo, numero de origen y numero de destino
        /// </summary>
        /// <param name="ll1">Primera llamada a analizar</param>
        /// <param name="ll2">Segunda llamada a analizar</param>
        /// <returns>True si son iguales el tipo, numero de origen y numero de destino.
        /// False si algun parametro no es igual</returns>
        public static bool operator ==(Llamada ll1, Llamada ll2)
        {
            if (ll1.Equals(ll2) && 
                ll1.NroOrigen == ll2.NroOrigen && 
                ll1.NroDestino == ll2.NroDestino )
                 return true;

            return false;
        }

        /// <summary>
        /// Compara la igualdad de dos llamadas, segun el tipo, numero de origen y numero de destino
        /// </summary>
        /// <param name="ll1">Primera llamada a analizar</param>
        /// <param name="ll2">Segunda llamada a analizar</param>
        /// <returns>False si son iguales el tipo, numero de origen y numero de destino.
        /// True si algun parametro no es igual</returns>
        public static bool operator !=(Llamada ll1, Llamada ll2)
        {
            return !(ll1 == ll2);
        }
        #endregion

        #region Enums
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        #endregion
    }
}
