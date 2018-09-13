using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] numbers = new double[20];
            for(int i = 0; i<numbers.Length; i++)
            {
                double n = random.Next((int)(1 - (random.NextDouble() * 10)), (int)(random.NextDouble() * 10));
                if (n != 0)
                    numbers[i] = n;
                else
                    i--;
            }

            Array.Sort(numbers);
            for (int i = (numbers.Length -1); i > 0; i--)
                if (numbers[i] >= 0)
                    Console.WriteLine("" + numbers[i]);

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] <= 0)
                    Console.WriteLine("" + numbers[i]);

            Console.ReadLine();
        }
    }
}
