using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ej_26Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack numbers = new Stack();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                double n = random.Next((int)(1 - (random.NextDouble() * 10)), (int)(random.NextDouble() * 10));
                if (n != 0)
                    numbers.Push(n);
                else
                    i--;
            }
            int length = numbers.Count;
            int min, max;
            max = (int)numbers.Peek();
            min = max;
            for(int i = 0; i < length; i++){
                Console.WriteLine("" + numbers.Pop());
            }
            Console.ReadLine();
        }
    }
}
