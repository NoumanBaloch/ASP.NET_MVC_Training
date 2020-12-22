using CalculatorLibrary;
using SOLID;
using SOLID.LSP;
//using SOLID.LiskovWrong;
using SOLID.OpenClosedPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator.Calculate();
            //Product.Stock();
            //Employee empjohn = new PermanentEmployee(1, "john");
            //Employee empJason = new TemporaryEmployee(2, "Jason");


            //Employee empMike = new ContractEmployee(3, "Mike");
            //Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
            //    empJohn.ToString(),
            //    empJohn.CalculateBonus(100000).ToString()));
            //Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
            //  empJason.ToString(),
            //  empJason.CalculateBonus(150000).ToString()));
            //Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
            //  empMike.ToString(),
            //  empMike.CalculateBonus(150000).ToString()));



            //A Better Way

            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TemporaryEmployee(2, "Jason"));
            //Un Comment to see the error
            //mployees.Add(new ContractEmployee(3, "Mike"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
                employee.ToString(),
                employee.CalculateBonus(100000).ToString(),
                employee.GetMinimumSalary().ToString()));
            }

            Console.WriteLine();

            List<IEmployee> employeesOnly = new List<IEmployee>();

            employeesOnly.Add(new PermanentEmployee(1, "John"));


            employeesOnly.Add(new TemporaryEmployee(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3, "Mike"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumSalary().ToString()));
            }
            Console.ReadKey();
        }

    }
}
