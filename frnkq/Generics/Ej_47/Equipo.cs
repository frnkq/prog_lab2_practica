using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_47
{
    public abstract class Equipo
    {

        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public string Ficha
        {
            get
            {
                return String.Format("{0} fundado en {1}", nombre, fechaCreacion.Date);
            }
        }

        public string Mostrar()
        {
            return this.nombre;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.Ficha.Equals(e2.Ficha);
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
    }
}
