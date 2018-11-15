using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            try
            {
                XmlWriter xmlWriter = XmlWriter.Create(rutaArchivo);
                XmlSerializer ser = new XmlSerializer(typeof(T));
            
                ser.Serialize(xmlWriter, objeto);
                xmlWriter.Close();
                return true;
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException("Error al guardar archivo",e);
            }

        }

        public T Leer(string rutaArchivo)
        {
            XmlReader xmlReader = XmlReader.Create(rutaArchivo);
            XmlSerializer ser = new XmlSerializer(typeof(T));
            T datos;
            try
            {
                datos = (T)ser.Deserialize(xmlReader);
                return datos;
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException("Error al leer archivo",e );
            }
            finally
            {
                xmlReader.Close();
            }
            
        }
    }
}
