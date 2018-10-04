using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #region Nested Types
    public enum TipoManada
    {
        Unica,
        Mixta
    }
    #endregion
    public class Grupo
    {
        #region fields
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;
        #endregion

        #region Properties
        /// <summary>
        /// Propiedad de solo escritura para el campo Tipo
        /// </summary>
        public TipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Constructor estatico que inicializa tipo en TipoManada.Unica
        /// </summary>
        static Grupo()
        {
            tipo = TipoManada.Unica;
        }

        /// <summary>
        /// Constructor utilizado para inicializar manada
        /// </summary>
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        /// <summary>
        /// Constructor nombre, setea el nombre e inicializa la manada utilizando 
        /// el constructor Grupo()
        /// </summary>
        /// <param name="nombre">Nombre de la manada</param>
        public Grupo(String nombre) : this()
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// Constructor publico, setea nombre y tipo.
        /// Utiliza constructor privado Grupo() para inicializar manada
        /// </summary>
        /// <param name="nombre">Nombre del grupo</param>
        /// <param name="tipo">Tipo del grupo</param>
        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {
            this.Tipo = tipo;
        }

        /// <summary>
        /// Retorna la informacion del Grupo, incluyendo las descripciones individuales
        /// de las Mascota de la lista manada
        /// </summary>
        /// <param name="e">Grupo del cual se colectara la informacion</param>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("**{0}**", this.nombre));
            foreach(Mascota mascota in this.manada)
            {
                sb.AppendLine(mascota.ToString());
            }
            return sb.ToString();
        }


        /// <summary>
        /// Un grupo sera igual a una mascota si esta ultima forma parte de la lista
        /// </summary>
        /// <param name="e">Grupo donde se buscara j</param>
        /// <param name="j">Mascota a ser buscada en e</param>
        /// <returns>True si j esta en la lista e.manada, false de lo contrario</returns>
        public static bool operator ==(Grupo e, Mascota j)
        {
            foreach(Mascota mascota in e.manada)
            {
                if (mascota.GetType() == typeof(Perro) )
                    return (mascota == j);
                else if (mascota.GetType() == typeof(Gato))
                    return (mascota == j);
            }

            return false;
        }
        /// <summary>
        /// Un grupo sera distinto a una mascota si esta ultima nio forma parte de la lista
        /// </summary>
        /// <param name="e">Grupo donde se buscara j</param>
        /// <param name="j">Mascota a ser buscada en e</param>
        /// <returns>True si j ni esta en la lista e.manada, false de lo contrario</returns>
        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        /// <summary>
        /// Si una mascota existe en la lista manada del grupo, se podra agregar 
        /// con el operador +
        /// </summary>
        /// <param name="e">Grupo en el que se buscara la mascota</param>
        /// <param name="j">Mascota a buscar en el grupo</param>
        /// <returns>El grupo con sus modificaciones de haber sido hechas</returns>
        public static Grupo operator +(Grupo e, Mascota j)
        {
            if (!(e == j))
                e.manada.Add(j);

            return e;
        }

        /// <summary>
        /// Si una mascota existe en la lista manada del grupo, se podra eliminar 
        /// con el operador -
        /// </summary>
        /// <param name="e">Grupo en el que se buscara la mascota</param>
        /// <param name="j">Mascota a buscar en el grupo</param>
        /// <returns>El grupo con sus modificaciones de haber sido hechas</returns>
        public static Grupo operator -(Grupo e, Mascota j)
        {
            if (e == j)
                e.manada.Remove(j);

            return e;
        }
        #endregion
    }
}
