using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//BASIC and horrible dec to bin
//while (numero > 0 || numero < 0)
//{
//    resto = numero % 2;
//    binary = binary + "" + resto;
//    if (numero > 0)
//        numero = Math.Floor((double)numero / 2);
//    else
//        numero = Math.Ceiling((double)numero / 2);
//}
////reverts the string as 'binary' is backwards
//for (int i = binary.Length - 1; i >= 0; i--)
//{
//    retorno = retorno + binary.ElementAt(i);
//}

namespace Entidades
{
    public class Numero
    {
        private double numero;
        private string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }

        public Numero() { }
        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            //TODO: validacion?
                this.numero = (double)ValidarNumero(numero);
        }

        /// <summary>
        /// Valida que el valor recibido sea numerico y lo retorna en formato double, de no ser numerico, retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>El valor del parametro en formato double si este es numerico, 0 si no lo es</returns>
        private double ValidarNumero(string strNumero)
        {
            double number;
            if (double.TryParse(strNumero, NumberStyles.AllowDecimalPoint | NumberStyles.AllowTrailingSign, 
                CultureInfo.CurrentCulture, out number))
            {
                return number;
            }
            return 0;
        }

        /// <summary>
        /// Convierte un numero binario representado en un string, a un numero decimal
        /// </summary>
        /// <param name="binario">String que representa el numero binario</param>
        /// <returns>Devuelve el numero decimal que representa el binario, en formato string</returns>
        public string BinarioDecimal(string binario)
        {
            foreach(char c in binario)
                if(c != '0' && c != '1')
                    return "Valor invalido";

            double numero = 0;
            for (int i = 0; i < binario.Length; i++)
            {
                int digito = int.Parse(binario.ElementAt(i).ToString());
                numero += digito * Math.Pow(2, binario.Length - i - 1);
            }
            return numero.ToString();
        }

        /// <summary>
        /// Convierte un numero decimal a un numero binario
        /// </summary>
        /// <param name="numero">Numero decimal a ser convertido en binario</param>
        /// <returns>Devuelve el numero binario que representa al decimal, en formato string</returns>
        public string DecimalBinario(double numero)
        {
            if (numero.Equals((double)0))
                return numero.ToString();
     
            string binary = "";
            while (numero > 0)
            {
                binary = (Math.Round(numero) % 2).ToString() + binary;
                numero = Math.Floor((double)numero / 2);            
            }
            return binary;
        }


        /// <summary>
        /// Convierte un numero decimal a un numero binario
        /// </summary>
        /// <param name="numero">Numero decimal a ser convertido en binario</param>
        /// <returns>Devuelve el numero binario que representa al decimal, en formato string</returns>
        public string DecimalBinario(string numero)
        {
            double number;
            if (double.TryParse(numero, out number))
            {
                return DecimalBinario(number);
            }   
            return "Valor invalido";
  
        }

        /**Operators**/
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
           return n1.numero* n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
                return -1; //TODO: change this value
            return n1.numero / n2.numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        /**\Operators**/
        

    }
}
