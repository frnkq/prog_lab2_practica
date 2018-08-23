using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Clase1_ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            char exit = 'n';
            int employeeQty;
            int hourValue = 0;
            double totalSalaries = 0;
            double totalDiscounts = 0;
            double totalPayment = 0;
            ArrayList employeesList = new ArrayList();
            do
            {
                hourValue = Inputs.getNumber("Ingrese el valor de la hora");
                employeeQty = Inputs.getNumber("Ingrese la cantidad de empleados");
                for(int i = 0; i < employeeQty; i++)
                {
                    employeesList.Add(Employee.registerEmployee(hourValue));
                }

                foreach(Employee e in employeesList)
                {
                    Employee.printEmployee(e);
                    totalSalaries += e.salary + e.salaryDiscount;
                    totalDiscounts += e.salaryDiscount;
                    totalPayment += e.salary;
                }
                writeFooter(totalSalaries, totalDiscounts, totalPayment);
                exit = Inputs.getChar("Desea salir? s/n");
            } while (exit == 'n');

        }
        public static void writeFooter(double totalSalaries, double totalDiscounts, double totalPayment)
        {
            Console.WriteLine("Total de salarios: {0} - Total de descuentos {1} - Total a pagar: {2}",
                            totalSalaries, totalDiscounts, totalPayment);
        }
    }
}
