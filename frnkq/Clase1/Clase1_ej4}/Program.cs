using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int foundPretties = 0;
            for(int i = 1; i < int.MaxValue; i++)
            {
                if (checkIfPretty(i))
                {
                    foundPretties++;
                    Console.WriteLine("Pretty number found: " + i);
                }
                if (foundPretties == 4)
                    break;
                
            }

            Console.ReadKey();
        }
        public static bool checkIfPretty(int n)
        {
            int sum = 0;
            for (int k = 1; k < n; k++)
            {
                if( n % k == 0)
                {
                    sum += k; 
                }
            }
            if (sum == n)
                return true;
            return false;
        }
    }
}
