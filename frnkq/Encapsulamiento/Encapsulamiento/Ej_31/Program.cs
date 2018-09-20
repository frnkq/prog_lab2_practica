using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente carlos = new Cliente(1, "Carlos");
            Cliente elizabeth = new Cliente(2, "Elizabeth");
            Cliente frank = new Cliente(3, "Frank");
            Cliente charles = new Cliente(4, "Charles");
            Cliente charly = new Cliente(4, "Charly");

            Negocio n = new Negocio("La ferreteria de Juan");
            bool added;

            added = n + carlos;
            if (added)
                Console.WriteLine("Llego " + carlos.Nombre);

            added = n + elizabeth;
            if (added)
                Console.WriteLine("Llego " + elizabeth.Nombre);

            added = n + frank;
            if (added)
                Console.WriteLine("Llego " + frank.Nombre);

            added = n + charles;
            if (added)
                Console.WriteLine("Llego " + charles.Nombre);

            added = n + charly;
            if (added)
                Console.WriteLine("Llego " + charly.Nombre);

            for(int i = 0; i < 4;i++)
            {
                bool atender = ~n;
            }

            Console.ReadKey();
        }
    }
}
