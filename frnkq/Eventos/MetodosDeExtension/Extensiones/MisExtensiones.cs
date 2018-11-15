using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensiones
{
    public static class MisExtensiones
    {
        public static string CountDigits(this int number)
        {
            return number.ToString().Length + " digitos";
        }
    }
}
