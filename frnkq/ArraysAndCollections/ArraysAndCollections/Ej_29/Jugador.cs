using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_29
{
    public class Jugador
    {
        private long dni;
        private string nombre;
        public int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;

        }

        public float GetPromedioGoles()
        {
            return (this.partidosJugados == 0) ? 0 : (this.totalGoles / this.partidosJugados);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Jugador {0}, Dni: {1}, Total goles: {2} partidos jugados: {3} promedio g/p: {4}",
                                        this.nombre, this.dni, this.totalGoles, this.partidosJugados, this.GetPromedioGoles()));
            return sb.ToString(); ;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
