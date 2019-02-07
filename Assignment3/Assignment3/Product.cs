using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Product
    {
        public Product(string Name, double Price, int Quantity, string Type)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Type = Type;
        }

        public override string ToString()
        {
            return this.Name + ", " + this.Price + " RS, " + this.Quantity + ", " + this.Type;
        }

        internal string Name { get; set; }
        internal double Price { get; set; }
        internal int Quantity { get; set; }
        internal string Type { get; set; }
    }
}
