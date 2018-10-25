using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serializacion;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona myPerson = new Persona("fran", "kito");
            Persona.Guardar(myPerson);
        }
    }
}
