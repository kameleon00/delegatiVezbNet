using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace delegatiVezbNet2
{
    class Program
    {
        public delegate bool FilterDelegate(Employee employee);

        public struct Employee // zaposleni 
        {
            public string Name;
            public double Salary; //plata
        }
        //=========================================================================
        //=========================================================================
        static bool IsMinimum(Employee employee)
        {
            return employee.Salary < 1500;
        }
        static bool IsMedian(Employee employee)
        {
            return employee.Salary > 1500 & employee.Salary < 3000;
        }
        static bool IsMaximum(Employee employee)
        {
            return employee.Salary > 3000;
        }
        static void DisplaySalaries(string title, List<Employee> employees, FilterDelegate filter)
        {
            WriteLine(title + Environment.NewLine);

            foreach(Employee employee in employees)
            {
                if (filter(employee))
                {
                    WriteLine($"{employee.Name}, {employee.Salary.ToString("C")}");//.ToString("C") STAMPA FUNTU
                }
            }
            WriteLine(Environment.NewLine);
        }
        //=========================================================================
        //=========================================================================
        static void Main(string[] args)
        {
            string line = new String('-', 20);

            Employee employee1;
            employee1.Name = "Marko";
            employee1.Salary = 4000;

            Employee employee2;
            employee2.Name = "Stefan";
            employee2.Salary = 2000;

            Employee employee3;
            employee3.Name = "Vukasin";
            employee3.Salary = 1200;

            Employee employee4;
            employee4.Name = "David";
            employee4.Salary = 5000;

            List<Employee> employees = new List<Employee> { employee1, employee2, employee3, employee4 };
           
            //=========================================================================
            WriteLine("SALARIES: ");
            WriteLine(line);

            DisplaySalaries("Minimum salaries: ", employees, IsMinimum);
            WriteLine(line);
            DisplaySalaries("Median salaries: ", employees, IsMedian);
            WriteLine(line);
            DisplaySalaries("High salaries: ", employees, IsMaximum);
            WriteLine(line);

            ReadKey();
        }
    }
}
