using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public void Guardar(string archivo, string datos)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo;

            if (!File.Exists(path))
                File.Create(path);

            StreamWriter sw = new StreamWriter(archivo);
            try
            {
                sw.Write(datos);
            }
            catch (Exception e)
            {
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public void Leer(string archivo, out string datos)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo;


            if (!File.Exists(path))
            {
                datos = "";
                return;
            }

            StreamReader sr = new StreamReader(archivo);
            datos = "";
            try
            {
                datos = sr.ReadToEnd();
            }
            catch (Exception e)
            {
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
