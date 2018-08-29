using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_ej18
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;


        private float GetArea()
        {
            return this.area;
        }
        private float GetPerimetro()
        {
            return this.perimetro;
        }

        private Punto GetVertice1()
        {
            return this.vertice1;
        }

        private Punto GetVertice2()
        {
            return this.vertice2;
        }

        private Punto GetVertice3()
        {
            return this.vertice3;
        }

        private Punto GetVertice4()
        {
            return this.vertice4;
        }
        public float Area()
        {
            float baseP = Math.Abs(this.vertice1.GetX()) + Math.Abs(this.vertice2.GetX());
            float alturaP = Math.Abs(this.vertice1.GetY()) + Math.Abs(this.vertice4.GetY());
            this.area = baseP * alturaP;

            return this.area;
        }

        public float Perimetro()
        {
            float baseP = Math.Abs(this.vertice1.GetX()) + Math.Abs(this.vertice2.GetX());
            float alturaP = Math.Abs(this.vertice1.GetY()) + Math.Abs(this.vertice4.GetY());
            this.perimetro = ((baseP * 2) + (alturaP * 2));

            return this.perimetro;
        }
        private Rectangulo()
        {
            this.area = 0;
            this.perimetro = 0;
        }
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            Punto vertice2 = new Objetos_ej18.Punto(Math.Abs(vertice3.GetX()), Math.Abs(vertice1.GetY()));
            Punto vertice4 = new Punto(Math.Abs(vertice1.GetX()), Math.Abs(vertice3.GetY()));

            this.vertice1 = vertice1;
            this.vertice2 = vertice2;
            this.vertice3 = vertice3;
            this.vertice4 = vertice4;
        }

        public static String PrintRect(Rectangulo r)
        {

            return "Vertice 1 X:" + r.GetVertice1().GetX() + " Y:" + r.GetVertice1().GetY() +
                   "Vertice 2 X:" + r.GetVertice2().GetX() + " Y:" + r.GetVertice2().GetY() +
                   "Vertice 3 X:" + r.GetVertice3().GetX() + " Y:" + r.GetVertice3().GetY() +
                   "Vertice 4 X:" + r.GetVertice4().GetX() + " Y:" + r.GetVertice4().GetY() +
                   "Area: " + r.GetArea() + " Perimetro: " + r.GetPerimetro();
                  
        }
    }
}
