using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = unidades;
            this.Color = color;
        }

        public bool Recargar(int unidades)
        {
            if (unidades < 0)
                return false;
            else
                this.UnidadesDeEscritura += unidades;

            return true;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            foreach (char c in texto)
                this.UnidadesDeEscritura -= (float).3;
            return new EscrituraWrapper(texto, this.Color);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Boligrafo");
            sb.AppendLine("Color: " + this.Color.ToString());
            sb.AppendLine("Unidades de escritura: " + this.UnidadesDeEscritura);
            return sb.ToString();
        }
    }
}
