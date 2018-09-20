using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private String nombre;

        private Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                bool succeded = this + value;
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente client in n.clientes)
            {
                if(client == c)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            PuestoAtencion p = new PuestoAtencion(PuestoAtencion.Puesto.Caja2);
            Cliente client = n.Cliente;
            if (p.Atender(client))
            {
                Console.WriteLine("Cliente " + client.Nombre + " atendido");
                return true;
            }
                
            return false;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }
        
    }
}
