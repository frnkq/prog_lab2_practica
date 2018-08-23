using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_ej8
{
    class Employee
    {
        public String name { get; set; }
        public int yearAntiquity { get; set; }
        public double salary { get; set; }
        public int workedHours { get; set; }
        public double salaryDiscount { get; set; }

        Employee()
        {
            this.name = "Undefined";
            this.yearAntiquity = 0;
            this.salary = 0;
            this.workedHours = 0;
            this.salaryDiscount = 0;
        }
        Employee(String name, int yearAntiquity, double salary, int workedHours, double salaryDiscount)
        {
            this.name = name;
            this.yearAntiquity = yearAntiquity;
            this.salary = salary;
            this.workedHours = workedHours;
            this.salaryDiscount = salaryDiscount;
        }

        public static Employee registerEmployee(int hourValue)
        {
            Employee myEmployee = new Clase1_ej8.Employee();
            myEmployee.name = Inputs.getString("Ingrese el nombre del empleado");
            myEmployee.yearAntiquity = Inputs.getNumber("Ingrese la antiguedad en años");
            myEmployee.workedHours = Inputs.getNumber("Ingrese las horas trabajadas de "+myEmployee.name);
            myEmployee.salary = hourValue * myEmployee.workedHours + (myEmployee.yearAntiquity*150);
            myEmployee.salaryDiscount = myEmployee.salary * 0.13;
            myEmployee.salary = myEmployee.salary - myEmployee.salaryDiscount;
            return myEmployee;
        }

        public static void printEmployee(Employee myEmployee)
        {
            Console.WriteLine("Empleado: {0} - Antiguedad {1} años - Salario {2} - Descuento {3}",
                myEmployee.name, myEmployee.yearAntiquity, myEmployee.salary, myEmployee.salaryDiscount);
        }
    }
}
