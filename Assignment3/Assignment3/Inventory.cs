using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Inventory
    {
        public Inventory()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
        }

        public void AddProductQuantity(string ProductName, int Quantity)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Name == ProductName)
                {
                    this.Products[i].Quantity += Quantity;
                    Console.WriteLine($"Quantity of {ProductName} : {this.Products[i].Quantity}");
                    break;
                }
            }
        }

        public int NumberOfProducts()
        {
            return Products.Count;
        }

        public void RemoveProduct(string Name)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Name == Name)
                {
                    this.Products.Remove(Products[i]);
                    break;
                }
            }
        }

        public int TotalPay(Dictionary<string,int> Purchase)
        {
            double TotalPay = 0;
            int TotalRoundPay = 0;
            foreach (var ProductName in Purchase)
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].Name == ProductName.Key)
                    {
                        TotalPay += (Products[i].Price * ProductName.Value);
                        break;
                    }
                }
            }
            TotalRoundPay = (int) Math.Ceiling(TotalPay);
            return TotalRoundPay;
        }

        public void DisplayProductByType(string Type)
        {
            Console.WriteLine($"Products List By Type : {Type}");
            Console.WriteLine();
            foreach (var Product in Products)
            {
                if (Product.Type == Type)
                {
                    Console.WriteLine(Product.ToString());
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Products List : ");
            Console.WriteLine();
            foreach (var Product in Products)
            {
                Console.WriteLine(Product.ToString());
            }
        }

        private List<Product> Products;
    }
}
