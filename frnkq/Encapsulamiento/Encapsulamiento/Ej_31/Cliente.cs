using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_31
{
    class Cliente
    {
        private string nombre;
        private int numero;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        
        public int Numero
        {
            get
            {
                return numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre)
        {
            this.numero = numero;
            this.nombre = nombre;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
        
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }
    }
}
