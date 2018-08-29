using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_ej16
{
    class Alumno
    {
        private byte _nota1 { get; set; }
        private byte _nota2 { get; set; }
        private float notaFinal { get; set; }
        private String apellido { get; set; }
        private int legajo { get; set; }
        private String nombre { get; set; }

        public Alumno(byte n1, byte n2)
        {
            this._nota1 = n1;
            this._nota2 = n2;
        }

        public Alumno(String apellido, String nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public Alumno(byte n1, byte n2, String apellido, int legajo, String nombre)
        {
            this._nota1 = n1;
            this._nota2 = n2;
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random r = new Random();
                this.notaFinal = (float)r.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte n1, byte n2)
        {
            this._nota1 = n1;
            this._nota2 = n2;

            this.CalcularFinal();
        }

        public String Mostrar()
        {
            Console.WriteLine("Alumno: {0} {1} - Legajo nº{2}", this.apellido, this.nombre, this.legajo);
            Console.WriteLine("Nota1: {0} Nota 2: {1}", this._nota1, this._nota2);
            if (this.notaFinal != -1)
                Console.WriteLine("Nota final: {0}", this.notaFinal);
            else
                Console.WriteLine("Alumno desaprobado");
            return "";
        }
    }
}
