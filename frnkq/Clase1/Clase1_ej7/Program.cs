using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 0;
            int month = 0;
            int year = 0;
            char salir = 'n';
            do
            {
                int lifeLivedDays = DateTime.Now.Day * DateTime.Now.Month * DateTime.Now.Year;
                Console.WriteLine("La vida tiene: {0} dias, {1} meses, {2} años. {3} dias total", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, lifeLivedDays);
                day = askNumber("Ingrese dia");
                month = askNumber("Ingrese mes");
                year = askNumber("Ingrese año");
                int livedDays = countLivedDays(day, month, year, DateTime.Now);
                if(livedDays != 0)
                {
                    Console.WriteLine("Lived days: "+ livedDays);
                }else{
                    Console.WriteLine("Error");
                }
                Console.WriteLine("Desea salir? s/n");
                var exit = Console.ReadLine();
                salir = char.Parse(exit.ToString());
            } while (salir == 'n');

        }

        public static int countLivedDays(int day, int month, int year, DateTime currentDate)
        {
            if (day > 0 && month > 0 && year > 0)
            {
               //TODO: do diffrent calculations based on años bisiestos
               //day nº tanto = year * month * day
               int lifeLivedDays = 30 * currentDate.Month * currentDate.Year + currentDate.Day;
               int livedDays = (30*month*year+ day) - lifeLivedDays; 

               return livedDays;
            }
            Console.WriteLine("Input data: {0} days {1} months {2} years", day, month, year);

            return 0;
        }

        public static bool checkIfBisiesto(int year)
        {
            if (year % 4 == 0)
            {
                if ((year % 400 == 0 && year % 100 == 0 || year % 100 != 0))
                    return true;
            }
            return false;
        }

        public static int askNumber(String message)
        {
            Console.WriteLine(message);
            var value = Console.ReadLine();
            int number;
            bool success = int.TryParse(value, out number);
            if (success)
                return number;

            return 0;
        }
    }
}
