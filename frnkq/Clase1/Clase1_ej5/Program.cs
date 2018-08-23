using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 0;
            do
            {
                Console.Title = "Centros numericos";
                limit = askNumber();
                checkCentricsToLimit(limit);
            } while (limit != 0);
        }

        public static int askNumber()
        {
            Console.WriteLine("Ingrese un limite hasta encontrar el numero. Ingrese cero o cualquier valor para finalizar");
            var value = Console.ReadLine();
            int number;
            bool success = int.TryParse(value, out number);
            if (success)
                return number;

            return 0;
        }

        public static void checkCentricsToLimit(int limit)
        {
            if (limit <= 0)
                return;
            for(int i = 0; i < limit; i++)
            {
                if (makeTheSumsOfTheSections(i))
                    Console.WriteLine("Centric number found: " + i);
            }
        }

        public static bool makeTheSumsOfTheSections(int number)
        {
            int sumBefore = 0;
            int sumAfter = 0;


            for (int k = 0; k<number; k++)
            {
                sumBefore += k;
                
            }

            for (int j = number+1; j < int.MaxValue; j++)
            {
                sumAfter += j;
                if (sumAfter > sumBefore)
                    break;
                if (sumAfter == sumBefore)
                    return true;
            }
            return false;
        }
    }
}
