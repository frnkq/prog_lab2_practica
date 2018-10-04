using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadFinanciera;
using PrestamosPersonales;
namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Financiera financiera = new Financiera("Mi Financiera");
            PrestamoDolares pd1 = new PrestamoDolares(1500, new DateTime(2017, 11, 01),
                PeriodicidadDePagos.Mensual);
            PrestamoDolares pd2 = new PrestamoDolares(2000, new DateTime(2017, 12, 05),
                PeriodicidadDePagos.Bimestral);
            PrestamoDolares pd3 = new PrestamoDolares(2500, new DateTime(2018, 01, 01),
                PeriodicidadDePagos.Bimestral);

            PrestamoPesos pp1 = new  PrestamoPesos(8000, new DateTime (2018, 01, 01), 20);
            PrestamoPesos pp2 = new PrestamoPesos(7000, new DateTime(2001, 10, 01), 25);
            PrestamoPesos pp3 = new PrestamoPesos(5000, new DateTime(2017, 11, 20), 20);

            financiera = financiera + pd1;
            financiera = financiera + pd2;
            financiera = financiera + pd3;
            financiera = financiera + pd3; //Prestamo repetido

            financiera = financiera + pp1;
            financiera = financiera + pp2;
            financiera = financiera + pp3;
            financiera = financiera + pp3; //Prestamo repetido

            Console.WriteLine((String)financiera);

            pd1.ExtenderPlazo(new DateTime(2017, 12, 01));
            pp1.ExtenderPlazo(new DateTime(2018, 02, 01));

            financiera.OrdenarPrestamos();

            Console.WriteLine("\n *********************ORdenados por fecha*************");
            Console.WriteLine(Financiera.Mostrar(financiera));
            Console.ReadKey();


        }
    }
}
