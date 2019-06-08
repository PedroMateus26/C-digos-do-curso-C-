using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFiles.Entity
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            

        }

        public double total()
        {
            return this.Quantity * this.Price;
        }
    }
}
