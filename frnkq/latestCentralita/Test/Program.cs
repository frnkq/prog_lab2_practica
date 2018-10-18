using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            
                
            try
            {
                c = c + l1;
            }
            catch (CentralitaException e)
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine(e.Message);
                Console.WriteLine(l1.ToString());
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!");

            }

            try
            {
                c += l2;
            }
            catch (CentralitaException e)
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine(e.Message);
                Console.WriteLine(l2.ToString());
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!");
            }

            try
            {
                c += l3;
            }
            catch (CentralitaException e)
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine(e.Message);
                Console.WriteLine(l3.ToString());
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!");
            }

            try
            {
                c += l4;
            }
            catch (CentralitaException e)
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine(e.Message);
                Console.WriteLine(l4.ToString());
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine();
            }

        

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());            
            Console.ReadKey();
        }
    }
}
