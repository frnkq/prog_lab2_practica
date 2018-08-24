using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_ej14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double x)
        {
            if (x == 0)
                return 0;

            return x * x;
        }

        public static double CalcularTriangulo(double n, double h)
        {
           if(n == 0 || h == 0 )
                return 0;

            return n * h;
        }

        public static double CalcularCirculo(double r)
        {
            if(r==0)
                return 0;

            return Math.PI * Math.Pow(r, 2);
        }
    }
}
