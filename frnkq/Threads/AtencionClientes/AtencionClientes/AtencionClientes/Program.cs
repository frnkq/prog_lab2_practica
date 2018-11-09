using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Entidades;
namespace AtencionClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();

            Negocio negocio = new Negocio(caja1, caja2);

            negocio.Clientes.Add("Carlos");
            negocio.Clientes.Add("Alberto");
            negocio.Clientes.Add("Juan");
            negocio.Clientes.Add("Josefa");
            negocio.Clientes.Add("Franco");
            negocio.Clientes.Add("Federico");
            negocio.Clientes.Add("Victoria");

            Thread asignarCajas = new Thread(negocio.AsignarCaja);
            Thread atenderClientesCaja1 = new Thread(caja1.AtenderClientes);
            atenderClientesCaja1.Name = "Caja 1";

            Thread atenderClientesCaja2 = new Thread(caja2.AtenderClientes);
            atenderClientesCaja2.Name = "Caja 2";


            asignarCajas.Start();
            asignarCajas.Join();
            atenderClientesCaja1.Start();
            atenderClientesCaja2.Start();

        }
    }
}
