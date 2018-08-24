using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_ej12
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
            int n = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                n += int.Parse(Console.ReadLine());

                Console.WriteLine("Desea continuar? S/N");
                continuar = Console.ReadKey().KeyChar;
            } while (Validacion.ValidaS_N(continuar));
            Console.WriteLine("Suma: " + n);
            Console.ReadKey();
        }
    }
}
