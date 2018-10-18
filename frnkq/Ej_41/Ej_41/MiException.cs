using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_41
{
    public class MiException : Exception
    {
        public MiException()
        {
        }

        public MiException(string message) : base(message)
        {
        }
        public MiException(string message, Exception inner) : base(message, inner)
        {
        }
        
    }
}
