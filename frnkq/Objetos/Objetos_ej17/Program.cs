using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_ej17_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Objetos_ej17_pens.Boligrafo blue = new Objetos_ej17_pens.Boligrafo(ConsoleColor.Blue);
            Objetos_ej17_pens.Boligrafo red = new Objetos_ej17_pens.Boligrafo(ConsoleColor.Red);
            String dibujo;

            Console.ForegroundColor = blue.GetColor();
            blue.Pintar(50, out dibujo);
            Console.WriteLine(dibujo);

            Console.ReadKey();

            Console.ForegroundColor = red.GetColor();
            red.Pintar(20, out dibujo);
            Console.WriteLine(dibujo);

            Console.ReadKey();
        }
    }
}
