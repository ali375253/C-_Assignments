using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    abstract class Employee
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected string Designation { get; set; }
        protected int Experience { get; set; }
        protected double AnnualSalary { get; set; }
        protected DateTime JoiningDate { get; set; }

        public abstract void TotalAnnualSalary();
        public abstract void Display();
    }
}
