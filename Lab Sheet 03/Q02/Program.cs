using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Q02.Program;

namespace Q02
{
    internal class Program
    {
        public class Employee
        {
            // Private fields
            private int employeeID;
            private string fullName;
            private double salary;

            // Properties
            public int EmployeeID
            {
                get
                {
                    return employeeID;
                }
            }

            public string FullName
            {
                get
                {
                    return fullName;
                }
                set
                {
                    fullName = value;
                }
            }

            public double Salary
            {
                get
                {
                    return salary;
                }
            }

            // Constructor
            public Employee(int employeeID, string fullName, double salary)
            {
                this.employeeID = employeeID;
                this.fullName = fullName;
                this.salary = salary;
            }

            // Methods to display employee details
            public void DisplayEmployeeDetails()
            {
                Console.WriteLine($"Employee ID: {employeeID}");
                Console.WriteLine($"Full Name: {fullName}");
                Console.WriteLine($"Salary: {salary}");
            }
        }

        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "John Doe", 50000);
            Console.WriteLine($"Employee ID: {employee1.EmployeeID}");
            employee1.FullName = "Jane Doe";
            Console.WriteLine("\nEmployee Information after updating full name:");
            employee1.DisplayEmployeeDetails();

            Console.ReadLine();
        }
    }
}
