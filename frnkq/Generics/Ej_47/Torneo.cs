using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            equipos = new List<T>();
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                return CalcularPartido(equipos[random.Next(equipos.Count)], equipos[random.Next(equipos.Count)]);
            }
        }

        public static bool operator ==(Torneo<T> torneo, T e2)
        {
            foreach (T equipo in torneo.equipos)
            {
                if (equipo.Equals(e2))
                    return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T e2)
        {
            return !(torneo == e2);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
                torneo.equipos.Add(equipo);
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Torneo: " + this.nombre);
            foreach (T equipo in this.equipos)
                sb.AppendLine(equipo.Mostrar());

            return sb.ToString();
        }

        private string CalcularPartido<U> (U equipo1, U equipo2)  where U : Equipo
        {
            Random random = new Random();
            return String.Format("{0} {1} - {2} {3}",
                equipo1.Mostrar(), random.Next(0, 10), random.Next(0, 10), equipo2.Mostrar());
        }
    }
}
