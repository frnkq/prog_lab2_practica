using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_ej20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar d = new Dolar(32.5);
            Euro e = (Euro)d;
            Console.WriteLine("dolar: {0} euro: {1}", d.GetCantidad(), e.GetCantidad());

            Console.ReadKey();
        }
    }
}
