using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_ej20
{
    class Peso 
    {
        public static double inDolars = 0.0570;
        public static double inEuros = 23.94;


        private double cantidad;
        private float cotizRespectoDolar;

        public Peso()
        { }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            this.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }


    }
}
