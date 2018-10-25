using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_52
{
    class Cartuchera2
    {
        public List<Boligrafo> boligrafos = new List<Boligrafo>();
        public List<Lapiz> lapices = new List<Lapiz>();

        public bool ProbarElementos()
        {
            bool flag = false;
            foreach(Lapiz l in lapices)
            {
                ((IAcciones)l).Escribir("123");
                if (((IAcciones)l).UnidadesDeEscritura < 1)
                    ((IAcciones)l).Recargar(1);
            }

            foreach(Boligrafo b in boligrafos)
            {
                if (b.UnidadesDeEscritura < 1)
                    flag = true;
                else
                    b.Escribir("0123456789");

                if (b.UnidadesDeEscritura < 1)
                    b.Recargar(1);
            }

            return !flag;
        }
    }
}
