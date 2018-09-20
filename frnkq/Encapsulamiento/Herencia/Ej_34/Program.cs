using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(3, 5, 2, 8, Colores.Blanco);
            Console.WriteLine(camion.cantidadMarchas +"-"+ camion.pesoCarga + "-" + camion.cantidadRuedas + "-" + camion.cantidadPuertas + "-" + camion.color);

            Console.ReadLine();
        }
    }
}
