using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_33
{
    class Libro
    {
        private List<string> paginas;
        
        public string this[int i]
        {
            get
            {
                if(i>0 && i<(paginas.Count-1))
                   return paginas[i];
                return "";
            }
            set
            {
                if (i >= (paginas.Count-1))
                    paginas.Add(value);
                else
                    paginas[i] = value;
                
            }
        }

        public Libro()
        {
            this.paginas = new List<string>();
        }
    }
}
