using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serializacion
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(Persona p)
        {
            FileStream fs;         //Objeto que escribirá en binario.
            BinaryFormatter ser;   //Objeto que serializará.

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePath = filePath + "\\Persona.cs";

            //Se indica ubicación del archivo binario y el modo.
            fs = new FileStream(filePath, FileMode.Create);
            
            //Se crea el objeto serializador.
            ser = new BinaryFormatter();
           
            //Serializa el objeto p en el archivo contenido en fs.
            ser.Serialize(fs, p);
            
            //Se cierra el objeto fs
            fs.Close();

        }

        public static Persona Leer()
        {
            return new Persona("asd", "asd");
        }

        public override string ToString()
        {
            return "-> " + this.nombre + " " + this.apellido;
        }
    }
}
