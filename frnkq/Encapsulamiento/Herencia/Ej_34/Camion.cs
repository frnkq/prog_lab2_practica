using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_34
{
    class Camion : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantidadMarchas, int pesoCarga,
                    short cantidadRuedas, short cantidadPuertas, Colores color) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
    }
}
