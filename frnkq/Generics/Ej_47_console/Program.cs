using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej_47;
namespace Ej_47_console
{
    class Program
    {
        static void Main(string[] args)
        {
            EquipoBasquet equipoBasquetUno = new EquipoBasquet("Equipo de basquet 1", new DateTime(2002, 5, 20));
            EquipoBasquet equipoBasquetDos = new EquipoBasquet("Equipo de basquet 2", new DateTime(2012, 5, 20));
            EquipoBasquet equipoBasquetTres = new EquipoBasquet("Equipo de basquet 3", new DateTime(2022, 5, 20));

            EquipoFutbol equipoFutbolUno = new EquipoFutbol("Equipo de futbol 1", new DateTime(1196, 5, 20));
            EquipoFutbol equipoFutbolDos = new EquipoFutbol("Equipo de futbol 2", new DateTime(1198, 5, 20));
            EquipoFutbol equipoFutbolTres = new EquipoFutbol("Equipo de futbol 3", new DateTime(1200, 5, 20));

            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo de basquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo de futbol");

            torneoBasquet += equipoBasquetUno;
            torneoBasquet += equipoBasquetDos;
            torneoBasquet += equipoBasquetTres;

            torneoFutbol += equipoFutbolUno;
            torneoFutbol += equipoFutbolDos;
            torneoFutbol += equipoFutbolTres;

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine("------------------");
            Console.WriteLine(torneoFutbol.Mostrar());

            Console.ReadKey();

            Console.WriteLine(torneoBasquet.JugarPartido);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(torneoBasquet.JugarPartido);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(torneoBasquet.JugarPartido);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();
            Console.WriteLine("------------------");

            Console.WriteLine(torneoFutbol.JugarPartido);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(torneoFutbol.JugarPartido);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(torneoFutbol.JugarPartido);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.ReadKey();
        }
    }
}
