using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_ej10
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = Inputs.getNumber("Ingrese el numero magico");
            for (int j = 0; j < magicNumber; j++)
            {
                

                for (int i = 0; i <= j; i++)
                { 
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
