using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_ej11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int max = int.MinValue;
            int min = int.MaxValue;
            int prom = 0;
            for(int i = 0; i<3; i++)
            {
                int n = -1;
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    n = int.Parse(Console.ReadLine());

                   
                } while(!Validacion.Validar(n, -100, 100));
              
                if (n < min)
                    min = n;
                if (n > max)
                    max = n;
                prom += n;
            }
            prom = prom / 3;
            Console.WriteLine("Maximo: {0} Minimo {1} Promedio {2}", max, min, prom);
            Console.ReadKey();
        }
    }
}
