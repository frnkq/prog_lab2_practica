using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_ej14
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
            int opcion;
            do
            {
                Console.WriteLine("¿Que operación desea realizar?");
                Console.WriteLine("1 - Calcular area de un cuadrado");
                Console.WriteLine("2 - Calcular area de un triangulo");
                Console.WriteLine("3 - Calcular area de un circulo");

                int.TryParse(Console.ReadKey().KeyChar.ToString(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese la longitud de cualquiera de los lados del cuadrado");
                        double n;
                        double.TryParse(Console.ReadLine(), out n);
                        Console.WriteLine("El area del cuadrado es: "+CalculoDeArea.CalcularCuadrado(n));
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la base del triangulo");
                        double m;
                        double.TryParse(Console.ReadLine(), out m);

                        Console.WriteLine("Ingrese la altura del triangulo");
                        double h;
                        double.TryParse(Console.ReadLine(), out h);

                        Console.WriteLine("El area del triangulo es: " + CalculoDeArea.CalcularTriangulo(m, h));
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el radio de la circunferencia");
                        double r;
                        double.TryParse(Console.ReadLine(), out r);
                        Console.WriteLine("El area de la circunferencia es: " + CalculoDeArea.CalcularCirculo(r));
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta, intente de nuevo");
                        break;
                }

                Console.WriteLine("Desea continuar? S/N");
                continuar = Console.ReadKey(true).KeyChar;
            } while (Validacion.ValidaS_N(continuar));
        }
    }
}
