using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteInvalidaException : Exception
    {
        public PatenteInvalidaException(string msg) : base (msg) { }

        public PatenteInvalidaException(string msg, Exception innerException) : base(msg, innerException) { }
    }
}
