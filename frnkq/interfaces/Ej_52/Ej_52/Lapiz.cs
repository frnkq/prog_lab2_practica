using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_52
{
    public class Lapiz  : IAcciones
    {
        private float tamanoMina;

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanoMina;
            }
            set
            {
                this.tamanoMina = value;
            }
        }

        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura += unidades;
        }


        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            foreach(char c in texto)
                ((IAcciones)this).UnidadesDeEscritura -= (float).1;
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lapiz");
            sb.AppendLine("Color: " + ((IAcciones)this).Color.ToString());
            sb.AppendLine("Unidades de escritura: " + ((IAcciones)this).UnidadesDeEscritura);
            return sb.ToString();
        }
    }
}
