using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_ej18
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto p1 = new Punto(0, 0);
            Punto p3 = new Punto(4, 2);
            Rectangulo r = new Rectangulo(p1, p3);
            r.Perimetro();
            r.Area();
            Console.WriteLine(Rectangulo.PrintRect(r));
            Console.ReadKey();
        }
    }
}
