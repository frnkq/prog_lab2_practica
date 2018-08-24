using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_ej11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor > max || valor < min)
                Console.WriteLine("Numero fuera de rango");
                return false;
            return true;
                
        }
    }
}
