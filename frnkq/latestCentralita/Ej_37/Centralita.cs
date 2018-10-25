using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        #region Fields
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;
        #endregion

        #region Properties
        /// <summary>
        /// Read only. Calcula las ganancias por llamadas locales
        /// </summary>
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        /// <summary>
        /// Read only. Calcula las ganancias por llamadas provinciales
        /// </summary>
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        /// <summary>
        /// Read only. Calcula las ganancias por todas las llamadas.
        /// </summary>
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        /// <summary>
        /// Read only. Retorna la lista de llamadas
        /// </summary>
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public string RutaDeArchivo
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        
        public Centralita(String nombreEmrpesa) : this()
        {
            this.razonSocial = nombreEmrpesa;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Recopila informacion de la centralita
        /// </summary>
        /// <returns>Información de la centralita</returns>
        public override string ToString()
        {
            StringBuilder datosCentralita = new StringBuilder();
            datosCentralita.AppendLine("CENTRALITA: " + this.razonSocial);
            datosCentralita.AppendLine("Ganancia total: " + this.GananciasPorTotal);
            datosCentralita.AppendLine("Gancancia por provincial: " + this.GananciasPorProvincial);
            datosCentralita.AppendLine("Gancancia por local: " + this.GananciasPorLocal);
            datosCentralita.AppendLine("Detalle de las llamadas");
            foreach (Llamada llamada in this.listaDeLlamadas)
                datosCentralita.Append(llamada.ToString());

            return datosCentralita.ToString();
        }

        /// <summary>
        /// Agrega una llamada a la lista de llamadas
        /// </summary>
        /// <param name="nuevaLlamada">Nueva llamada a agregar</param>
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        /// <summary>
        /// Ordena el listado de las llamadas utilizando el comparador Llamada.OrdenarPorDuracion
        /// </summary>
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

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

        /// <summary>
        /// Genera un log de la centralita
        /// Dia dd de month de yyyy hh:hh hs se realizo una llamada
        /// </summary>
        /// <returns></returns>
        public bool Guardar()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                              "\\" +
                              "CentralitaLog.txt";
            try
            {
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.WriteLine(String.Format("{0} {1} de {2} de {3} {4}:{5}hs - Se realizó una llamada",
                              DateTime.Now.DayOfWeek.ToString(), DateTime.Now.Day.ToString(),
                              DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(),
                              DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString()));
                sw.Close();
            }catch(Exception e)
            {
                throw e;
            }
            
            return true;
        }

        public string Leer()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                               "\\" +
                               "CentralitaLog.txt";
            string data;

            StreamReader sr = new StreamReader(filePath);
            try
            {
                data = sr.ReadToEnd();
                sr.Close();
                return data;
            }catch(Exception e)
            {
                throw e;
            }
            


            throw new NotImplementedException();
        }
        #endregion

        #region Operators

        /// <summary>
        /// Analiza si una llamada existe en la lista de llamadas de la centrfalita utilizando
        /// el operador == de llamada
        /// </summary>
        /// <param name="c">Centralita a analizar</param>
        /// <param name="llamada">Llamada a verificar si existe en la lista de llamadas</param>
        /// <returns>True si la llamada existe en la lista de llamadas, false si no existe</returns>
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach(Llamada ll in c.Llamadas)
            {
                if (ll == llamada)
                    return true;
            }

            return false;
        }
        /// <summary>
        /// Analiza si una llamada existe en la lista de llamadas de la centrfalita utilizando
        /// el operador == de llamada
        /// </summary>
        /// <param name="c">Centralita a analizar</param>
        /// <param name="llamada">Llamada a verificar si existe en la lista de llamadas</param>
        /// <returns>False si la llamada existe en la lista de llamadas, true si no existe</returns>
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        /// <summary>
        /// Agrega una llamada a la lista de llamadas de la centralita solo si esta no existe,
        /// tal verificacion se hace utilizando el operador == de Centralita
        /// </summary>
        /// <param name="c">Centralita a analizar</param>
        /// <param name="nuevaLlamada">Llamada a agregar en caso de no existir</param>
        /// <returns>Centralita c</returns>
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
                try
                {
                    c.Guardar();
                }catch(Exception e)
                {
                    throw new FallaLogException("Error al guardar log :(");
                }

            }
            else
            {
                throw new CentralitaException("Error: La llamada ya se encuentra registrada");
            }
                

            return c;
        }
        #endregion
    }
}
