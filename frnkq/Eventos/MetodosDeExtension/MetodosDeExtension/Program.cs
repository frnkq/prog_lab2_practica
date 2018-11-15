using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensiones;
namespace MetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese un numero");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n.CountDigits());

                Console.ReadKey();
            } while (true);
            
        }
    }
}
