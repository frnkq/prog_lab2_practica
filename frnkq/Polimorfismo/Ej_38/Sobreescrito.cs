using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_38
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public abstract string MiPropiedad
        {
            get;
        }

        public Sobreescrito()
        {
            miAtributo = "Probar abstractos";
        }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            if (obj is Sobreescrito)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
