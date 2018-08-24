using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_ej13
{
    class Conversor
    {
        public static String decimalBinario(double n)
        {
            double resto;
            String binary = "";
            while (n > 0)
            {
                resto = n % 2;
                binary = binary+""+ resto;
                n = Math.Floor(n / 2);
            }
            string retorno = "";
            for(int i = binary.Length -1 ; i>= 0; i--)
            {
                retorno = retorno + binary.ElementAt(i);
            }
            return retorno;
        }

        public static double binarioDecimal(String binary)
        {
            Console.WriteLine("Numero antes de todo: " + binary);
            double numero = 0;
            for(int i = 0; i < binary.Length; i++)
            {
                int digito = int.Parse(binary.ElementAt(i).ToString());
                numero += digito * (2^(4-i));

                
            }
            Console.WriteLine("Numero magico: " + numero);
            return numero;
        }
    }
}
