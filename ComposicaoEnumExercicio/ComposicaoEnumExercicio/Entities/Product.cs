using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoEnumExercicio.Entities
{
    class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

    }
}
