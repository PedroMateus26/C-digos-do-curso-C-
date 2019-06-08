using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLambdaProposto.Entities
{
    class Product
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Price { get; set; }

        public Product(string name, string email, double price)
        {
            Name = name;
            Email = email;
            Price = price;
        }
    }
}
