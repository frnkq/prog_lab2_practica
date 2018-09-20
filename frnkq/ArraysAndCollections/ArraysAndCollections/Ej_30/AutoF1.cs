using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_30
{
    class AutoF1
    {
        private short cantCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public string MostrarDatos()
        {
            return (String.Format("Cant combustible{0}"));
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1==a2);
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (String.Compare(a1.escuderia, a2.escuderia) == 0) ? true : false;
        }
    }
}
