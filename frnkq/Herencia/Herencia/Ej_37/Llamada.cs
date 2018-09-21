using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        /**Fields**/
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        /**Properties**/
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        /**Constructors**/
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        /**Public methods**/
        public string Mostrar()
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

        
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
