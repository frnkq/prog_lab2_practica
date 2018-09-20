using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Pagina 1 - Introduccion";
            libro[1] = "Pagina 2 - Titulo del libro";
            libro[2] = "Pagina 3 - Charles chaplin";
            libro[3] = "Pagina 4 - No se";

            Console.WriteLine(libro[3]);
            Console.WriteLine(libro[25]);

            libro[1] = "Modified 1";
            libro[2] = "Modified 2";
            libro[10] = "Added 945";

            Console.WriteLine(libro[1]);
            Console.WriteLine(libro[2]);
            Console.WriteLine(libro[10]);

            Console.ReadKey();
        }
    }
}
