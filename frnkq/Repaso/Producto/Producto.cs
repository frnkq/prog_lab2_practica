using System;
using System.Collections.Generic;
using System.Text;

namespace Producto
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca() { return this.marca; }
        public float GetPrecio() { return this.precio; }

        public static string MostrarProducto(Producto p)
        {
            return "Producto cod: "+(string)p+" marca: " + p.GetMarca() + " precio: " + p.GetPrecio();
        }

        /**OPERATORS**/
        public static explicit operator string(Producto p)
        {
            return "";// p.codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p.GetMarca().Equals(marca);
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p==marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            
            return (p1 == p2.GetMarca() && (string)p1 == (string)p2);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
