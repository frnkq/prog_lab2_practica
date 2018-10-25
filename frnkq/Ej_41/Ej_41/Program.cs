using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;
namespace Ej_41
{
    class Program
    {

        public static void Main(string[] args)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = DateTime.Now.Year.ToString() +
                              DateTime.Now.Month.ToString() +
                              DateTime.Now.Day.ToString() +
                              "-" +
                              DateTime.Now.Hour.ToString() +
                              DateTime.Now.Minute.ToString() +
                              ".txt";
            string filePath = desktopPath + "\\" + fileName;
            try
            {
                new Divider(5, "asd");
            }
            catch(MiException e)
            {
              
                ArchivoTexto.Guardar(filePath, Divider.GetStack(e));
            }

            Console.WriteLine(ArchivoTexto.Leer(filePath));
            Console.ReadKey();
        }
       
    }
}
