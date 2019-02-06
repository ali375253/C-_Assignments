using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Id : ");
            int Id= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name : ");
            string Name = Console.ReadLine();
   
            Console.WriteLine("Enter the Deparatment Name : ");
            string DepartmentName = Console.ReadLine();

            Employee employee = new Employee(Id,Name,DepartmentName);
            employee.MethodCalled += OnMethodCalled;

            Console.WriteLine("Id : " + employee.GetId());
            Console.WriteLine("Name : " + employee.GetName());
            Console.WriteLine("Department Name : " + employee.GetDepartmentName());

            //Updating Employee Details
            employee.UpdateEmployee(12,"Aliasgar","Development");

            //Displaying Updated Details
            Console.WriteLine("Id : " + employee.GetId());
            Console.WriteLine("Name : " + employee.GetName());
            Console.WriteLine("Department Name : " + employee.GetDepartmentName());
        }

        static void OnMethodCalled(string MethodName)
        {
            Console.WriteLine($"{ MethodName} method called");
        }
    }
}
