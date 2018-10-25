using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Notepad
{
    public class Notepad : IManageFiles
    {
        private string filePath;
        public string FilePath
        {
            get
            {
                return this.filePath;
            }
            set
            {
                this.filePath = value;
            }
        }

        public void Guardar(string data)
        {
            StreamWriter sw = new StreamWriter(this.FilePath);
            try
            {
                sw.WriteLine(data);
            }catch(Exception e)
            {
            }
            finally
            {
                if(!(sw is null))
                {
                    sw.Close();
                }
            }
        }

        public string Leer()
        {
            string data = "";

            try
            { 
                StreamReader sr = new StreamReader(this.FilePath);

                try
                {
                    data = sr.ReadToEnd();
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    if (!(sr is null))
                    {
                        sr.Close();
                    }
                }
            }catch(Exception e)
            {

            }

           
            return data;
        }
    }
}
