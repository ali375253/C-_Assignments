using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory ProductInventorySystem = new Inventory();

            ProductInventorySystem.AddProduct(new Product("lettuce", 10.5, 50, "Leafy green"));
            ProductInventorySystem.AddProduct(new Product("cabbage", 20, 100, "Cruciferous"));
            ProductInventorySystem.AddProduct(new Product("pumpkin", 30, 30, "Marrow"));
            ProductInventorySystem.AddProduct(new Product("cauliflower", 10 , 25, "Cruciferous"));
            ProductInventorySystem.AddProduct(new Product("zucchini", 20.5 , 50, "Marrow"));
            ProductInventorySystem.AddProduct(new Product("yam", 30 , 50, "Root"));
            ProductInventorySystem.AddProduct(new Product("spinach", 10 , 100, "Leafy green"));
            ProductInventorySystem.AddProduct(new Product("broccoli", 20.2 , 75, "Cruciferous"));
            ProductInventorySystem.AddProduct(new Product("garlic", 30 , 20, "Leafy green"));
            ProductInventorySystem.AddProduct(new Product("silverbeet", 10 , 50, "Marrow"));

            Console.WriteLine($"Total Number of Products : {ProductInventorySystem.NumberOfProducts()}");
            Console.WriteLine();

            Console.WriteLine("After New Produce Added.");
            ProductInventorySystem.AddProduct(new Product("Potato", 10, 50, "Root"));
            ProductInventorySystem.Display();
            Console.WriteLine($"Total Number of Products : {ProductInventorySystem.NumberOfProducts()}");
            Console.WriteLine();
            Console.WriteLine();

            ProductInventorySystem.DisplayProductByType("Leafy green");
            Console.WriteLine();

            Console.WriteLine("After Garlic Removed.");
            ProductInventorySystem.RemoveProduct("garlic");
            Console.WriteLine($"Total Number of Products : {ProductInventorySystem.NumberOfProducts()}");
            Console.WriteLine();

            Console.WriteLine("After 50 Cabbage Added.");
            ProductInventorySystem.AddProductQuantity("cabbage", 50);
            Console.WriteLine();

            Console.WriteLine("After User Purchases.");
            var Purchase = new Dictionary<string,int>();
            Purchase.Add("lettuce",1);
            Purchase.Add("zucchini",2);
            Purchase.Add("broccoli", 1);
            Console.WriteLine($"Total Pay : {ProductInventorySystem.TotalPay(Purchase)}");
        }
    }
}
