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
            Dolar d = new Dolar(30);
            Peso p = new Peso(10);

            Peso dolarAPeso = (Peso)d;

            Dolar sumaPesoYDolar = d + p;

            Console.WriteLine("Dolar a peso: " + dolarAPeso.GetCantidad()+ " Suma: "+sumaPesoYDolar.GetCantidad());

            Console.ReadKey();
        }
    }
}
