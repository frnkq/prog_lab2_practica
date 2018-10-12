using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class CentralitaException : Exception
    {
        public CentralitaException()
        {

        }
        public CentralitaException(string message) : base(message)
        {

        }
        public CentralitaException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
