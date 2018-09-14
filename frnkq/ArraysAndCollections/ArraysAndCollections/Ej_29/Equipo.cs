using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_29
{
    class Equipo
    {
        private short cantJugadores;
        public List<Jugador> jugadores;
        private string nombre;
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Contains(j) || e.jugadores.Count() > e.cantJugadores)
                return false;

            e.jugadores.Add(j);
            return true;
        }
        public List<Jugador> GetJugadores()
        {
            return this.jugadores;
        }
    }
}
