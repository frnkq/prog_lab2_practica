using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            double cube;
            do
            {
                number = AskNumber();
                cube = Cubify(number);
                if (cube != -1)
                    Console.WriteLine("Cubo del numero: " + cube);
                else
                    number = 0;
            } while (number == 0);

            Console.ReadKey();
        }

        private static double AskNumber()
        {
            Console.WriteLine("Ingrese un numero mayor a cero para ser elevado al cuadrado");
            double number = 0;
            try
            {
                number = double.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("Numero ingresado erroneo");
                return 0;
            }
            return number;
        }

        private static double Cubify(double n)
        {
            if(n >= 0)
            {
                return Math.Pow(n, 3);
            }
            return -1;
        }
    }
}
