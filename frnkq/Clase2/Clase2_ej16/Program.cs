using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_ej15
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
            double n1;
            double n2;
            char operation;
            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                double.TryParse(Console.ReadLine(), out n1);

                Console.WriteLine("Ingrese el segundo numero: ");
                double.TryParse(Console.ReadLine(), out n2);

                Console.WriteLine("Ingrese la operacion deseada:");
                operation = Console.ReadKey().KeyChar;

                Calculadora.Calculate(n1, n2, operation);

                Console.WriteLine("Desea continuar? S/N");
                continuar = Console.ReadKey(true).KeyChar;
            } while (Validacion.ValidaS_N(continuar));
        }
    }
}
