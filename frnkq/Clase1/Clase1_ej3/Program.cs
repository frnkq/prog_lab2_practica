using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";
            int number = askNumber();
            printPrimes(number);

            Console.ReadKey();
        }
        public static int askNumber()
        {
            Console.WriteLine("Ingrese un numero: ");
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                return 0;
            }
            return number;
        }

        public static void printPrimes(int number)
        {
            if(number == 0)
            {
                Console.WriteLine("No hay ningun numero primo hasta ese numero");
                return;
            }
            
            if(number > 0){
                for(int i = 0; i < number ; i++)
                {
                    if(i % 2 != 0)
                        Console.WriteLine("Numero primo: " + i);
                }
            }
            else
            {
                for(int i = number; i >= 0; i++)
                {
                    if (i % 2 != 0)
                        Console.WriteLine("Numero primo: " + i);
                }
            }
            
        }
    }
}
