using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class HR : Employee
    {
        public HR(int Id, string Name, string Designation, int Experience, double AnnualSalary, DateTime JoiningDate )
        {
            this.Id = Id;
            this.Name = Name;
            this.Designation = Designation;
            this.Experience = Experience;
            this.AnnualSalary = AnnualSalary;
            this.JoiningDate = JoiningDate;
        }

        public override void TotalAnnualSalary()
        {
            AnnualSalary += (1000 * Experience);
        }

        public override void Display()
        {
            Console.WriteLine("HR Details : ");
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Designation : {Designation}");
            Console.WriteLine($"Experience : {Experience}");
            Console.WriteLine($"Annual Salary : {AnnualSalary}");
            Console.WriteLine($"Joining Date : {JoiningDate.Day}/{JoiningDate.Month}/{JoiningDate.Year}");
        }


    }
}
