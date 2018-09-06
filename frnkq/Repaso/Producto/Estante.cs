using System;
using System.Collections.Generic;
using System.Text;

namespace Producto
{
    class Estante
    {
        private Producto[] productos = null;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        
        public Estante(int capacidad, int ubicacion)
        {
            this.productos = new Estante(capacidad).GetProductos();
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }
        
        public static string MostrarEstante(Estante e)
        {
            string productos = "";
            foreach(Producto p in e.GetProductos())
            {
                productos+= Producto.MostrarProducto(p);
            }
            return "Estante ubicacion " + e.ubicacionEstante+" productos: "+productos;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            foreach(Producto productoEnEstante in e.GetProductos())
                if (p.Equals(productoEnEstante))
                    return true;
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e==p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            //si el producto no esta en el estante
            if(e != p)
            {
                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    if (e.GetProductos()[i] is null)
                    {
                        e.GetProductos()[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            //si el producto esta en el estante
                for(int i = 0; i < e.GetProductos().Length - 1; i++)
                {
                    if (e.GetProductos()[i].Equals(p))
                    {
                        e.GetProductos()[i] = null;
                        break;
                    }
                }
            return e;
        }
    }
}
