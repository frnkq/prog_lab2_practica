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
                countLivedDays(day, month, year, DateTime.Now);



                Console.WriteLine("Desea salir? s/n");
                var exit = Console.ReadLine();
                salir = char.Parse(exit.ToString());
            } while (salir == n);
        }

        public static int countLivedDays(int day, int month, int year, DateTime currentDate)
        {
            if (day > 0 && month > 0 && year > 0)
            {
                if (checkIfBisiesto(year))
                {

                }
                else
                {

                }
            }

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
    }
}
