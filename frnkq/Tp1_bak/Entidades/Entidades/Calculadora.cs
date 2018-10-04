using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        
        public double Operar(Numero num1, Numero num2, string operador)
        {
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return 0;
            }
        }
        private String ValidarOperador(string operador)
        {
            if (operador.Equals("+") || operador.Equals("-") ||
                operador.Equals("/") || operador.Equals("*"))
                return operador;
            return "+";
        }
    }
}
