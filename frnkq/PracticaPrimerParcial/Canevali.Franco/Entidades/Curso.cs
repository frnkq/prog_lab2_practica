using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        #region Fields
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;
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
        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profesor)
            : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        /// <summary>
        /// Recopila informacion del curso, incluyendo sus alumnos y el profesor
        /// </summary>
        /// <param name="c">Curso del cual se recopilara informacion</param>
        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Curso: {0}", c.AnioDivision));
            sb.AppendLine("Profesor: ");
            sb.AppendLine(c.profesor.ExponerDatos());
            sb.AppendLine("Alumnos:");
            foreach (Alumno a in c.alumnos)
            {
                sb.AppendLine(a.ExponerDatos());
                sb.AppendLine("----");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Agrega un alumno a la lista de alumnos del curso, siempre y cuando compartan anio y division
        /// </summary>
        /// <param name="c">Curso al cual se agregara el alumno</param>
        /// <param name="a">Alumno a agregar</param>
        /// <returns>Devuelve el curso</returns>
        public static Curso operator +(Curso c, Alumno a)
        {
            if (String.Compare(c.AnioDivision, a.AnioDivision) == 0)
                c.alumnos.Add(a);
            return c;
        }

        /// <summary>
        /// Verifica que el alumno exista en el curso, mediante la comparacion entre su anio y division
        /// </summary>
        /// <param name="c">Curso en el cual se buscara el alumno</param>
        /// <param name="a">Alumno que se buscara en el curso</param>
        /// <returns>True si se encuentra el alumno, false de lo contrario</returns>
        public static bool operator ==(Curso c, Alumno a)
        {
            foreach(Alumno al in c.alumnos)
                if (String.Compare(c.AnioDivision, al.AnioDivision)==0)
                    return true;
            return false;
        }

        /// <summary>
        /// Verifica que el alumno exista en el curso, mediante la comparacion entre su anio y division
        /// </summary>
        /// <param name="c">Curso en el cual se buscara el alumno</param>
        /// <param name="a">Alumno que se buscara en el curso</param>
        /// <returns>False si se encuentra el alumno, true de lo contrario</returns>
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c==a);
        }
        #endregion
    }
}
