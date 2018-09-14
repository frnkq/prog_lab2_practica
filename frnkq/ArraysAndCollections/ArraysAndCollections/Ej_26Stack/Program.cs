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

            object[] myArray = numbers.ToArray();
            Array.Sort(myArray);


            Stack positiveStacks = new Stack();
            Stack negativeStacks = new Stack();
            int myvar = 0;
           for(int i=0;i<myArray.Length / 2; i++)
            {
                positiveStacks.Push(myArray[i]);
            }


            int length = numbers.Count;
            for (int i = 0; i < positiveStacks.Count; i++)
                Console.WriteLine("asd" + positiveStacks.Pop());
            for (int i = 0; i < negativeStacks.Count; i++)
                //Console.WriteLine("" + positiveStacks.Pop());


            Console.ReadKey();
        }
    }
}
