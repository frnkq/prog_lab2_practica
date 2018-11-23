using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo;

            if (!File.Exists(path))
                File.Create(path);

            XmlWriter xmlWriter = XmlWriter.Create(archivo);
            XmlSerializer ser = new XmlSerializer(typeof(T));
            try
            {
                ser.Serialize(xmlWriter, datos);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                xmlWriter.Close();
            }

        }

        public void Leer(string archivo, out T datos)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\" + archivo;

            if (!File.Exists(path))
            {
                datos = default(T);
                return;
            }
                

            XmlReader xmlReader = XmlReader.Create(path);
            XmlSerializer ser = new XmlSerializer(typeof(T));
            try
            {
                datos = (T)ser.Deserialize(xmlReader);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                xmlReader.Close();
            }
        }
    }
}
