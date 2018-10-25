using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class FallaLogException : Exception
    {
        public FallaLogException()
        {

        }
        public FallaLogException(string message) : base(message)
        {

        }
        public FallaLogException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
