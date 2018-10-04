using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo un grupo y mascotas
            Grupo grupo = new Grupo("Grupo 1");

            Perro perroA = new Perro("Dog", "Cruza");
            Gato gatoA = new Gato("Macri", "Gato");

            Perro perroB = new Perro("god", "guau guagu", 23, true);
            Gato gatoB = new Gato("ircaM", "atoG");

            Perro perroC = new Perro("Perro", "Salchicha");
            Gato gatoC = new Gato("Gato", "Siames");

            Perro perroD = new Perro("orreP", "ahcihclaS");
            Gato gatoD = new Gato("otaG", "semaiS");

            //Imprimo informacion del grupo vacio
            Console.WriteLine(grupo.ToString());
            Console.ReadKey();

            //Agrego mascotas
            grupo += perroA;
            grupo += gatoB;
            grupo += gatoD;
            grupo += perroB;

            //Muestro el grupo con mascotas
            grupo.ToString();
            Console.ReadKey();

            //Elimino una mascota que no se encuentra
            grupo -= gatoC;
            Console.WriteLine(grupo.ToString());
            Console.ReadKey();

            //Elimino dos mascotas que si se encuentran
            grupo -= perroA;
            grupo -= perroB;
            Console.WriteLine(grupo.ToString());

            Console.ReadKey();
        }
    }
}
