using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_ej15
{
    class Calculadora
    {
        public static double Calculate(double x, double y, char operation)
        {
            switch (operation)
            {
                case '+':
                    ShowResult((x+y), false);
                    break;

                case '-':
                    ShowResult(x - y, false);
                    break;

                case '*':
                    ShowResult(x * y, false);
                    break;

                case '/':
                    if (Validate(y))
                        ShowResult(x / y, false);
                    else
                        ShowResult(0, true);
                    break;

                default:
                    ShowResult(0, true);
                    break;

            }
            return 0;
        }

        private static bool Validate(double x)
        {
            if (x != 0)
                return true;
            return false;
        }

        public static void ShowResult(double res, bool error)
        {
            if (error)
                Console.WriteLine("Hubo un error.");
            else
                Console.WriteLine("El resultado es: "+ res);                
        }
    }
}
