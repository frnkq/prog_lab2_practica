using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    interface IManageFiles
    {
        void Guardar(string data);
        string Leer();
        string FilePath
        {
            get;
            set;
        }
    }
}
