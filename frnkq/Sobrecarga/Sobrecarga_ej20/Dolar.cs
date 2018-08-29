using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_ej20
{
    class Dolar
    {

        public static double inPesos = 17.55;
        public static double inEuros = 0.7330;

        private double cantidad;
        private float cotizRespectoDolar;

        public Dolar()
        { }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion)
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

        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro(d.GetCantidad() * inEuros, (float)Dolar.inEuros);
            return e;
        }
        public static explicit operator Peso(Dolar d)
        {
            Peso p = new Sobrecarga_ej20.Peso(d.GetCantidad() * inPesos, (float)Dolar.inPesos);
            return p;
        }

        public static implicit operator Dolar(double d)
        {
            return d;
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1.GetCantidad() == d2.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            if (d1.GetCantidad() != d2.GetCantidad())
                return true;
            return false;
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            if (d.GetCantidad() == e.GetCantidad())
                return true;
            return false;
        }
        public static bool  operator !=(Dolar d, Euro e)
        {
            if (d.GetCantidad() != e.GetCantidad())
                return true;
            return false;
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            if (d.GetCantidad() != p.GetCantidad())
                return true;
            return false;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            if (d.GetCantidad() != p.GetCantidad())
                return true;
            return false;
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return d.cantidad + p.GetCantidad() * inPesos;
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return d.cantidad - p.GetCantidad() * inPesos;
        }
        public static Dolar operator +(Dolar d, Euro e) {
            return d.cantidad + e.GetCantidad() * inEuros;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return d.cantidad + e.GetCantidad() * inEuros;
        }
    }
}
