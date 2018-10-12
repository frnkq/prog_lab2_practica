using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_41
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion()
        {
        }

        public UnaExcepcion(string message) : base(message)
        {
        }

        public UnaExcepcion(string message, Exception inner) : base(message, inner)
        {
        }
        
    }
}
