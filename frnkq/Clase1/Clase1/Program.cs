using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_ej1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Clase 1 ejercicio 1";
        
            int numbers;
            int max = 0;
            int min = 0;
            int promedio = 0;

            Console.WriteLine("Ingrese 5 numeros");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                var number = int.Parse(Console.ReadLine());
                numbers = number;
                promedio += numbers;
                if (i == 0)
                {
                    max = numbers;
                    min = numbers;
                }

                if(numbers > max)
                {
                    max = numbers;
                }else if(numbers < min)
                {
                    min = numbers;
                }
                
            }
            
            promedio = promedio / 5;


            Console.WriteLine("Maximo: " + max);
            Console.WriteLine("Minimo: " + min);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadKey();
        }

        
    }
}

