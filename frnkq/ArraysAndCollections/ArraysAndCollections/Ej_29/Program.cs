using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador uno = new Jugador(1, "Tevez", 10, 2);
            Jugador dos = new Jugador(2, "Kenji", 63, 9);
            Jugador tres = new Jugador(3, "Hernan", 84, 14);
            Jugador cuatro = new Jugador(4, "Federico", 150, 3);
            Jugador cinco = new Jugador(5, "Matias", 150, 3);
            Jugador seis = new Jugador(6, "Federico", 150, 3);
            Jugador siete = new Jugador(7, "Matias", 150, 3);
            Jugador ocho = new Jugador(8, "Federico", 150, 3);
            Jugador nueve = new Jugador(9, "Matias", 150, 3);
            Jugador diez = new Jugador(10, "Federico", 150, 3);
            Jugador once = new Jugador(145, "Matias", 150, 3);
            Jugador doce = new Jugador(22, "Hernan", 84, 14);

            Equipo miEquipo = new Equipo(11, "River");
            bool foo = miEquipo + uno;
            foo = miEquipo + dos;
            foo = miEquipo + tres;
            foo = miEquipo + cuatro;
            foo = miEquipo + cinco;
            foo = miEquipo + seis;
            foo = miEquipo + siete;
            foo = miEquipo + ocho;
            foo = miEquipo + nueve;
            foo = miEquipo + diez;
            foo = miEquipo + once;
            foo = miEquipo + once;
            foo = miEquipo + once;
            foo = miEquipo + doce;

            foreach(Jugador j in miEquipo.GetJugadores())
            {
                Console.WriteLine(j.MostrarDatos());
            }

            Console.ReadKey();
        }
    }
}
