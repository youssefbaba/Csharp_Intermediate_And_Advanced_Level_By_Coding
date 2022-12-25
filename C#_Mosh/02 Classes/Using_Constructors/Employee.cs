using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Constructors
{
    public class Employee
    {
        // Fields
        public int Salary { get; set; }

        // Constructors
        public Employee()
        {
            Console.WriteLine("Base class constructor.");
        }
        public Employee(int annualSalary)
        {
            Salary = annualSalary;
        }
        public Employee(int weeklySalary , int numberOfWeeks)
        {
            Salary  = weeklySalary * numberOfWeeks;
        }

    }
}
