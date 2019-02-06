using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            HR hr = new HR(1, "Smruti", "HR", 4, 8000, new DateTime(2015, 3, 27));
            hr.TotalAnnualSalary();
            hr.Display();

            Console.WriteLine();

            Developer developer = new Developer(2, "Aliasgar", "Developer", 5, 8000, new DateTime(2014, 1, 7));
            developer.TotalAnnualSalary();
            developer.Display();
   
        }
    }
}
