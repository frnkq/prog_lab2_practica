using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona pers = new Persona("some", "thing");
            Persona.Guardar(pers);

            Console.WriteLine(Persona.Leer().ToString());

            Console.ReadKey();
        }
    }
}
