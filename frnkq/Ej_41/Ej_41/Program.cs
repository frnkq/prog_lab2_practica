using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_41
{
    class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                new Divider(5, "asd");
            }
            catch(MiException e)
            {
                Console.WriteLine(Divider.GetStack(e));
            }

            Console.ReadKey();
        }
       
    }
}
