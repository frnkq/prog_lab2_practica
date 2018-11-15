using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException()
        {

        }

        public ErrorArchivoException(string msg) : base(msg)
        {

        }

        public ErrorArchivoException(string msg, Exception inner) : base(msg, inner)
        {

        }
    }
}
