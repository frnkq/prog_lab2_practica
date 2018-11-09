using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public Negocio(Caja c1, Caja c2)
        {
            this.clientes = new List<string>();
            this.caja1 = c1;
            this.caja2 = c2;
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach(string s in this.clientes)
            {
                Random random = new Random();
                int caja;
                caja = random.Next(2);
                
                if (caja == 0)
                {
                    this.caja1.FilaClientes.Add(s);
                    Console.WriteLine(s+" Asignado a caja 1");
                }
                else
                {
                    this.caja2.FilaClientes.Add(s);
                    Console.WriteLine(s+" Asignado a caja 2");
                }
                System.Threading.Thread.Sleep(1000);
            }
            
        }

        
    }
}
