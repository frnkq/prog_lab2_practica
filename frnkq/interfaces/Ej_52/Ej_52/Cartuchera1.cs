using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej_52;
namespace Ej_52
{
    public class Cartuchera1
    {
        private List<IAcciones> acciones = new List<IAcciones>();

        public List<IAcciones> Acciones
        {
            get
            {
                return this.acciones;
            }
            set
            {
                this.acciones = value;
            }
        }

        public bool ProbarElementos()
        {
            bool flag = false;
            foreach (IAcciones a in this.Acciones)
            {
                if(a.UnidadesDeEscritura < 1)
                {
                    if (a is Boligrafo)
                        flag = true;
                }
                else
                {
                    if (a is Boligrafo)
                    {
                        a.Escribir("123");
                    }

                    if (a is Lapiz)
                    {
                        a.Escribir("0123456789");
                    }
                }
                
                if(a.UnidadesDeEscritura < 1)
                {
                    a.Recargar(1);
                }
            }

            return !flag;
        }
    }
}
