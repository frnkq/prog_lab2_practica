using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_34
{
    class VehiculoTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;
        
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
    }
}
