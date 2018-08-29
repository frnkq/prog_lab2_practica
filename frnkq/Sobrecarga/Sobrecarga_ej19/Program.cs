using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_ej19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sobrecarga_ej19.Sumador();

            int resultadoNumero = (int)s1.Sumar(3, 5);
            String resultadoString = s1.Sumar("5", "9");

            Console.WriteLine("S1: Num: " + resultadoNumero + " str: " + resultadoString);


            Sumador s2 = new Sobrecarga_ej19.Sumador();
            int resultadoNumeroS2 = (int)s2.Sumar(5, 10);
            String resultadoStringS2 = s2.Sumar("10", "20");

            Console.WriteLine("S2: Num: " + resultadoNumeroS2 + " str: " + resultadoStringS2);

            int cantidadDeSumas = (int)s1;
            int cantidadDeSumasS2 = (int)s2;
            long sumasSumadas = s1 + s2;
            Console.WriteLine("Cantidad de sumas de s1: " + cantidadDeSumas+ "suma de sumas: "+sumasSumadas);
            Console.WriteLine("Cantidad de sumas de s2: " + cantidadDeSumasS2 + "suma de sumas: " + sumasSumadas);

            if (s1|s2)
            {
                Console.WriteLine("Ambos tienen la misma cantidad de sumas");
            }

            Console.ReadKey();
        }
    }
}
