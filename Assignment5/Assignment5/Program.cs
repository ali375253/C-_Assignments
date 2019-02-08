using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> PMList = new Dictionary<int,string>();
            PMList.Add(1998, "Atal Bihari Vajpayee");
            PMList.Add(2014, "Narendra Modi");
            PMList.Add(2004, "Manmohan Singh");

            Console.WriteLine("Prime Minister of 2004 : " + PMList[2004]);

            PMList.Add(2019, "Narendra Modi");

            Console.WriteLine();
            Console.WriteLine("PM List Sorted by Year : ");
            var items = from year in PMList
                        orderby year.Key ascending
                        select year;
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Value} : {item.Key}");
            }
        }
    }
}
