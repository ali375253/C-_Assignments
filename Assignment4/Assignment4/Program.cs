using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> Dictionary = new List<String>();
            Dictionary.Add("Boat");
            Dictionary.Add("house");
            Dictionary.Add("cat");
            Dictionary.Add("river");
            Dictionary.Add("cupboard");

            Console.WriteLine("Plural of All Words : ");
            for(int i = 0; i < Dictionary.Count; i++) {
                Console.WriteLine($"{Dictionary[i] + "s"}");
            }
            Console.WriteLine();

            Console.WriteLine("Displaying second word after replaced with its synonym : ");
            Dictionary[1] = "home";
            Console.WriteLine(Dictionary[1]);
            Console.WriteLine();

            Console.WriteLine("After new word added : ");
            Dictionary.Add("sea");
            Console.WriteLine("Length : " + Dictionary.Count);
            Console.WriteLine();

            Console.WriteLine("List of words which contains the length of character as 7 : ");
            foreach (var word in Dictionary.Where(w => w.Length >= 7))
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();

            Console.WriteLine("The word on 3rd position : " + Dictionary[3]);
            Console.WriteLine();

            Console.WriteLine("Words in ascending order : ");
            foreach (var word in SortedDictionary(Dictionary))
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();

            Console.WriteLine("Reverse of an array : ");
            for(int i=Dictionary.Count-1; i>=0; i--)
            {
                Console.WriteLine(Dictionary[i]);
            }

            
        }

        public static IEnumerable<string> SortedDictionary(List<string> Dictionary)
        {
            return Dictionary.OrderBy(v => v);
        }
    }
}
