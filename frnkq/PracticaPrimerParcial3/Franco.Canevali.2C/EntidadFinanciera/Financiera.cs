using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;
namespace EntidadFinanciera
{
    public class Financiera
    {
        #region Fields
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;
        #endregion

        #region Properties
        /// <summary>
        /// Readonly. Calcula los intereses de todos los prestamos del tipo Dolar 
        /// en listaDePrestamos
        /// </summary>
        public float InteresesEnDolares
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }

        /// <summary>
        /// Readonly. Calcula los intereses de todos los prestamos del tipo Peso
        /// en listaDePrestamos
        /// </summary>
        public float InteresesEnPesos
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }

        /// <summary>
        /// Readonly. Calcula los intereses de todos los prestamos 
        /// en listaDePrestamos
        /// </summary>
        public float InteresesTotales
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }

        /// <summary>
        /// Readonly. Propiedad de acceso a la listaDePrestamos
        /// </summary>
        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        /// <summary>
        /// Readonly. Propiedad de acceso a razonSocial
        /// </summary>
        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Constructor privado utilizado unicamente para inicializar la lista de prestamos
        /// </summary>
        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        /// <summary>
        /// Constructor publico utilizado para establecer la razon social,
        /// utilizando el constructor privado Financiera() para inicializar
        /// la lista de prestamos.
        /// </summary>
        /// <param name="razonSocial">Razon social de la financiera</param>
        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        /// <summary>
        /// Devolverá una cadena, utilizando el operador sobreescrito string, 
        /// con los datos de la financiera
        /// </summary>
        /// <param name="financiera">Financiera de la cual se capturarán los datos</param>
        /// <returns>Datos capturados</returns>
        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        /// <summary>
        /// De acuerdo al TipoDePrestamo, devuelve una suma total de los intereses del correspondiente tipo
        /// </summary>
        /// <param name="tipo">Tipo de prestamo de los cuales se recopilar{a el interees</param>
        /// <returns>Interes total de los prestamos del TipoPrestamo tipo</returns>
        public float CalcularInteresGanado(TipoDePrestamo tipo)
        {
            float interesTotal = 0;
            foreach(Prestamo p in this.ListaDePrestamos)
            {
                switch (tipo)
                {
                    case TipoDePrestamo.Pesos:
                        if (p is PrestamoPesos)
                        {
                            PrestamoPesos prestamoPesos = (PrestamoPesos)p;
                            interesTotal += prestamoPesos.Interes;
                        }
                        break;

                    case TipoDePrestamo.Dolares:
                        if(p is PrestamoDolares)
                        {
                            PrestamoDolares prestamoDolares = (PrestamoDolares)p;
                            interesTotal += prestamoDolares.Interes;
                        }
                        break;

                    case TipoDePrestamo.Todos:
                        interesTotal = this.CalcularInteresGanado(TipoDePrestamo.Dolares) +
                                       this.CalcularInteresGanado(TipoDePrestamo.Pesos);
                        break;
                }

                return interesTotal;
            }
            return 0;
        }

        /// <summary>
        /// Ordenara la lista de prestamos utilizando el comparador Prestamo.OrdenarPorFecha()
        /// </summary>
        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        /// <summary>
        /// Colectara los datos de la financiera
        /// </summary>
        /// <param name="financiera">Financiera de la cual se colectaran los datos</param>
        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("Razon social: {0}", financiera.RazonSocial));
            sb.AppendLine(String.Format("Intereses totales: {0}", financiera.InteresesTotales));
            sb.AppendLine(String.Format("Intereses en pesos: {0}", financiera.InteresesEnPesos));
            sb.AppendLine(String.Format("Intereses en dolares: {0}", financiera.InteresesEnDolares));
            sb.AppendLine("Lista de prestamos ordenada por fecha de vencimiento: ");

            foreach (Prestamo p in financiera.ListaDePrestamos)
                sb.AppendLine(p.Mostrar());
            
            return sb.ToString();
        }

        /// <summary>
        /// Verifica si un prestamo está contenido en listaDePrestamos de la financiera
        /// </summary>
        /// <param name="financiera">Financiera donde se buscara el prestamo</param>
        /// <param name="prestamo">Prestamo a buscar en la financiera</param>
        /// <returns>True si el prestamo se encuentra en listaDePrestamos, false de lo contrario</returns>
        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            foreach(Prestamo p in financiera.listaDePrestamos)
            {
                if (p == prestamo)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica si un prestamo está contenido en listaDePrestamos de la financiera
        /// </summary>
        /// <param name="financiera">Financiera donde se buscara el prestamo</param>
        /// <param name="prestamo">Prestamo a buscar en la financiera</param>
        /// <returns>True si el prestamo no se encuentra en listaDePrestamos, false de lo contrario</returns>
        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        /// <summary>
        /// Permite la agregacion de un prestamo a listaDePrestamos de la financiera pasada por parametro,
        /// se agregara el prestamo siempre y cuando este no exista en listaDePrestamos
        /// </summary>
        /// <param name="financiera">Financiera a la cual se le agregara el prestamo</param>
        /// <param name="prestamoNuevo">Prestamo a agregar en la financiera</param>
        /// <returns>La Financiera pasada por parametro</returns>
        public static Financiera operator +(Financiera financiera,
            Prestamo prestamoNuevo)
        {
            if (financiera != prestamoNuevo)
                financiera.ListaDePrestamos.Add(prestamoNuevo);
            return financiera;
        }
        #endregion
    }
}
