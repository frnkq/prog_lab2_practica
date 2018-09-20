using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ej_31
{
    class PuestoAtencion
    {

        private static int numeroActual;
        private Puesto puesto;

        private static int NumeroActual
        {
            get
            {
                return numeroActual++;
            }
        }
           
        private PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente c1)
        {
            Console.WriteLine("Atendiendo a " + c1.Nombre);
            Random randomTime = new Random();

            Thread.Sleep(randomTime.Next(0,5)*1000);
            return true;
        }
        
        public enum Puesto
        {
            Caja1,
            Caja2
        }


    }
}
