using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        /**Fields**/
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;


        /**Properties**/
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        /**Constructors**/


        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        
        public Centralita(String nombreEmrpesa) : this()
        {
            this.razonSocial = nombreEmrpesa;
        }

        /**Public methods**/


        public string Mostrar()
        {
            StringBuilder datosCentralita = new StringBuilder();
            datosCentralita.AppendLine("CENTRALITA: " + this.razonSocial);
            datosCentralita.AppendLine("Ganancia total: " + this.GananciasPorTotal);
            datosCentralita.AppendLine("Gancancia por provincial: " + this.GananciasPorProvincial);
            datosCentralita.AppendLine("Gancancia por local: " + this.GananciasPorLocal);
            datosCentralita.AppendLine("Detalle de las llamadas");
            foreach (Llamada llamada in this.listaDeLlamadas)
                datosCentralita.Append(llamada.Mostrar());

            return datosCentralita.ToString();
        }

        /// <summary>
        /// Ordena el listado de las llamadas utilizando el comparador Llamada.OrdenarPorDuracion
        /// </summary>
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        /**Private methods**/

        /// <summary>
        /// Calcula los distintos totales de ganancia (ganancia por llamadas locales, ganancia por llamadas provinciales y ganancia total)
        /// </summary>
        /// <param name="tipo">Enumerado del tipo Llamada.TipoLlamada </param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                switch (tipo)        
                {
                    case Llamada.TipoLlamada.Local:
                        if(llamada is Local)
                        {
                            Local local = (Local)llamada;
                            ganancia += local.CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if(llamada is Provincial)
                        {
                            Provincial provincial = (Provincial)llamada;
                            ganancia += provincial.CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Todas:
                        ganancia = this.CalcularGanancia(Llamada.TipoLlamada.Local) + this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
                        break;

                    default:
                        ganancia = -1;
                        break;
                }

            }

            return ganancia;
        }
    }
}
