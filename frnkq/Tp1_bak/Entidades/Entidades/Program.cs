using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero n1 = new Numero("");

            //String decError = n1.BinarioDecimal("909");
            String decNoError = n1.BinarioDecimal("11011");

            //String decD = n1.DecimalBinario(808);
            //String decS = n1.DecimalBinario("303");
            //String h = n1.DecimalBinario(88.3);

            //Console.WriteLine("Bin (909) to dec in string -error-: " + decError);
            Console.WriteLine("Bin (11011) to dec in string no error" + decNoError);
            //Console.WriteLine("Dec from double (808) to binary: " + decD);
            //Console.WriteLine("Dec from string (303) to binary: " + decS);
            //Console.WriteLine("Dec from string (88.3) to binary error: " + h);

            Console.ReadLine();
        }
    }
}
