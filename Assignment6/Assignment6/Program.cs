using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        List<Employee> employeeList;
        List<Salary> salaryList;

        public Program()
        {
            employeeList = new List<Employee>() {
                new Employee(){ EmployeeID = 1, EmployeeFirstName = "Rajiv", EmployeeLastName = "Desai", Age = 49},
                new Employee(){ EmployeeID = 2, EmployeeFirstName = "Karan", EmployeeLastName = "Patel", Age = 32},
                new Employee(){ EmployeeID = 3, EmployeeFirstName = "Sujit", EmployeeLastName = "Dixit", Age = 28},
                new Employee(){ EmployeeID = 4, EmployeeFirstName = "Mahendra", EmployeeLastName = "Suri", Age = 26},
                new Employee(){ EmployeeID = 5, EmployeeFirstName = "Divya", EmployeeLastName = "Das", Age = 20},
                new Employee(){ EmployeeID = 6, EmployeeFirstName = "Ridhi", EmployeeLastName = "Shah", Age = 60},
                new Employee(){ EmployeeID = 7, EmployeeFirstName = "Dimple", EmployeeLastName = "Bhatt", Age = 53}
            };
            salaryList = new List<Salary>() {
                new Salary(){ EmployeeID = 1, Amount = 1000, Type = SalaryType.Monthly},
                new Salary(){ EmployeeID = 1, Amount = 500, Type = SalaryType.Performance},
                new Salary(){ EmployeeID = 1, Amount = 100, Type = SalaryType.Bonus},
                new Salary(){ EmployeeID = 2, Amount = 3000, Type = SalaryType.Monthly},
                new Salary(){ EmployeeID = 2, Amount = 1000, Type = SalaryType.Bonus},
                new Salary(){ EmployeeID = 3, Amount = 1500, Type = SalaryType.Monthly},
                new Salary(){ EmployeeID = 4, Amount = 2100, Type = SalaryType.Monthly},
                new Salary(){ EmployeeID = 5, Amount = 2800, Type = SalaryType.Monthly},
                new Salary(){ EmployeeID = 5, Amount = 600, Type = SalaryType.Performance},
                new Salary(){ EmployeeID = 5, Amount = 500, Type = SalaryType.Bonus},
                new Salary(){ EmployeeID = 6, Amount = 3000, Type = SalaryType.Monthly},
                new Salary(){ EmployeeID = 6, Amount = 400, Type = SalaryType.Performance},
                new Salary(){ EmployeeID = 7, Amount = 4700, Type = SalaryType.Monthly}
            };
        }

        public static void Main()
        {
            Program program = new Program();
            program.Task1();

            program.Task2();

            program.Task3();
        }

        public void Task1()
        {
            var EmployeeList = from employee in employeeList
                                 join salary in salaryList
                                 on employee.EmployeeID equals salary.EmployeeID
                                 select new
                                 {
                                     employee.EmployeeFirstName,
                                     salary.Amount
                                 } into employee
                                 group employee by employee.EmployeeFirstName into employee
                                 select new
                                 {
                                     Name = employee.Key,
                                     TotalSalary = employee.Sum(s => s.Amount)
                                 } into employee
                                 orderby employee.TotalSalary ascending
                                 select new
                                 {
                                     employee.Name,
                                     employee.TotalSalary
                                 };
            
            Console.WriteLine("Total Salary of all the employee with their corresponding names in ascending order of their salary : ");
            Console.WriteLine();
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine(employee.Name + " | " +employee.TotalSalary);
            }
        }
        public void Task2()
        {
            var SecondOldestEmployee = employeeList.OrderByDescending(e => e.Age)
                                       .Join(salaryList,e => e.EmployeeID, s => s.EmployeeID,(e,s)=> new
                                       {
                                           e.EmployeeID,
                                           e.EmployeeFirstName,
                                           e.EmployeeLastName,
                                           e.Age,
                                           s.Amount,
                                           s.Type
                                       })
                                       .Where(s => s.Type == SalaryType.Monthly)
                                       .Take(2)
                                       .Skip(1);
            Console.WriteLine("********************************************************");
            Console.WriteLine("Employee details of 2nd oldest employee including his/her total monthly salary : ");
            Console.WriteLine();
            foreach (var employee in SecondOldestEmployee)
            {
                Console.WriteLine($"{employee.EmployeeID} | {employee.EmployeeFirstName} | {employee.EmployeeLastName} | {employee.Age} | {employee.Amount}");
            }

        }

        public void Task3()
        {
            var EmployeeList = from employee in employeeList
                               join salary in salaryList
                               on employee.EmployeeID equals salary.EmployeeID
                               where employee.Age >= 30
                               select new
                               {
                                   employee.EmployeeFirstName,
                                   salary.Amount
                               } into employee
                               group employee by employee.EmployeeFirstName into employee
                               select new
                               {
                                   Name = employee.Key,
                                   MeanSalary = employee.Average(s => s.Amount)
                               };

            Console.WriteLine("********************************************************");
            Console.WriteLine("Mean of Monthly, Performance, Bonus salary of employees whose age is greater than 30 : ");
            Console.WriteLine();
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine($"{employee.Name} | {employee.MeanSalary:F2}");
            }

        }
    }

    public enum SalaryType
    {
        Monthly,
        Performance,
        Bonus
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int Age { get; set; }
    }

    public class Salary
    {
        public int EmployeeID { get; set; }
        public int Amount { get; set; }
        public SalaryType Type { get; set; }
    }
}
