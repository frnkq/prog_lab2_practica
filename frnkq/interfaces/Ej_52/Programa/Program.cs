using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej_52;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            Lapiz miLapiz2 = new Lapiz(3);
            Boligrafo miBoligrafo2 = new Boligrafo(2, ConsoleColor.Green);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);



            Cartuchera1 c1 = new Cartuchera1();
            c1.Acciones.Add(miLapiz);
            c1.Acciones.Add(miBoligrafo);
            Console.WriteLine("Probando elementos de cartuchera 1");
            try
            {
                Console.WriteLine(c1.ProbarElementos());
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not implemented..");
            }

            try
            {
                Console.WriteLine(c1.ProbarElementos());
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not implemented..");
            }

            try
            {
                Console.WriteLine(c1.ProbarElementos());
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not implemented..");
            }

            try
            {
                Console.WriteLine(c1.ProbarElementos());
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not implemented..");
            }

            Cartuchera1 c2 = new Cartuchera1();
            c2.Acciones.Add(miLapiz2);
            c2.Acciones.Add(miBoligrafo2);
            Console.WriteLine("Probando elementos de cartuchera 2");
            try
            {
                Console.WriteLine(c2.ProbarElementos());
            }catch(NotImplementedException e)
            {
                Console.WriteLine("Not implemented..");
            }

            try
            {
                Console.WriteLine(c2.ProbarElementos());
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not implemented..");
            }

            try
            {
                Console.WriteLine(c2.ProbarElementos());
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not implemented..");
            }

            try
            {
                Console.WriteLine(c2.ProbarElementos());
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not implemented..");
            }

            Console.ReadKey();
        }
    }
}
