using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            do
            {
                year = askNumber();
                if (checkIfBisiesto(year))
                    Console.WriteLine("Es año bisiesto");
            } while (year != 0);

        }

        public static int askNumber()
        {
            Console.WriteLine("Ingrese numero de año para verificar si este es bisiesto. Para salir ingrese 0 o cualquier caracter");
            var value = Console.ReadLine();
            int number;
            bool success = int.TryParse(value, out number);
            if (success)
                return number;

            return 0;
        }

        public static bool checkIfBisiesto(int year)
        {
            if(year % 4 == 0)
            {
                if ((year % 400 == 0 && year % 100 == 0 || year % 100 != 0))
                    return true;
            }
            return false;
        }
    }
}
