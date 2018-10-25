using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serializacion
{
    [Serializable]
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
            FileStream fs;            //Objeto que leerá en binario.
            BinaryFormatter ser;      //Objeto que Deserializará.
            Persona pers;
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePath = filePath + "\\Persona.cs";

            //Se indica ubicación del archivo binario y el modo.
            fs = new FileStream(filePath, FileMode.Open);
            //Se crea el objeto deserializador.
            ser = new BinaryFormatter();
            //Deserializa el archivo contenido en fs, lo guarda en aux.
            pers = (Persona)ser.Deserialize(fs);
            //Se cierra el objeto fs.
            fs.Close();
            return pers;
        }

        public override string ToString()
        {
            return "-> " + this.nombre + " " + this.apellido;
        }
    }
}

