using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_ej16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("Perez", "Juan", 107262);
            Alumno a2 = new Alumno("Carlitos", "Raul", 12312);
            Alumno a3 = new Alumno("Esteban", "Quito", 123123);

            a1.Estudiar(2, 4);
            a2.Estudiar(6, 8);
            a3.Estudiar(9, 9);

            a1.Mostrar();
            a2.Mostrar();
            a3.Mostrar();

            Console.ReadKey();
        }
    }
}
