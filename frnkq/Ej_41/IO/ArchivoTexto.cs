using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace IO
{
    public static class ArchivoTexto
    {
        public static bool Guardar(string path, string data)
        {
            StreamWriter sw = new StreamWriter(path, true);
            try
            {
                sw.WriteLine(String.Format("[{0}] - {1}", DateTime.Now.ToString(), data));
                sw.Close();
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static string Leer(string path)
        {
            string data;
            StreamReader sr = new StreamReader(path);
            try
            {
                data = sr.ReadToEnd();
                sr.Close();
                return data;
            }catch(Exception e)
            {
                throw e;
            }
        }
    }
}
