using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_ej19
{
    class Sumador
    {
        private int cantidadDeSumas;
        public static explicit operator int(Sumador s)
        {
            return s.cantidadDeSumas;
        }
        public static bool operator | (Sumador s1, Sumador s2)
        {
            if (s1.cantidadDeSumas == s2.cantidadDeSumas)
                return true;
            return false;
        }
        public static long operator + (Sumador s1, Sumador s2)
        {
            return s1.cantidadDeSumas + s2.cantidadDeSumas;
        }
        public Sumador()
        {

        }
        public Sumador(int cantidadSumas)
        {
            this.cantidadDeSumas = cantidadSumas; 
        }
        public long Sumar(long a, long b)
        {
            this.cantidadDeSumas ++;
            return a + b;
        }

        public string Sumar(String a, String b)
        {
            long an;
            long bn;
            long.TryParse(a, out an);
            long.TryParse(b, out bn);
            this.cantidadDeSumas++;
            return (an + bn).ToString();
        }

    }
}
