using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_ej9
{
    class Inputs
    {
        public static char getChar(String message)
        {
            Console.WriteLine(message);
            char myString = Console.ReadKey().KeyChar;
            return myString;
        }
        public static String getString(String message)
        {
            Console.WriteLine(message);
            String myString = Console.ReadLine();
            return myString;
        }

        public static int getNumber(String message)
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
