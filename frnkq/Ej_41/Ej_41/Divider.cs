using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_41
{
    class Divider
    {
        public static string GetStack(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            if (ex.InnerException == null)
            {
                return ex.Message;
            }
            else
            {
                sb.AppendLine(String.Format("{0}", ex.Message));
                sb.AppendLine(String.Format("Inner exception: {0}", GetStack(ex.InnerException)));
                return sb.ToString();
            }
        }

        /// <summary>
        /// Method used to force a "DividedByZero exception".
        /// </summary>
        public static void TryingToDivide()
        {
            //Dividing by zero
            try
            {
                int zero = 0;
                double magic = 5 / zero;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Constructor de Divider el cual hara un llamado al metodo TryingToDivide
        /// </summary>
        public Divider()
        {
            try
            {
                TryingToDivide();
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }

        }
        
        public Divider(int number)
        {
            try
            {
                new Divider();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("No se puede dividir por cero, unaexecpcion", e);
            }
        }


        public Divider(int number, string something)
        {
            try
            {
                new Divider(5);
            }
            catch(UnaExcepcion e)
            {
                throw new MiException("miexcepcion", e);
            }
        }
    }
}
