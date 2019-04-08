using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoEnumExercicio.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public double SubTotal()
        {
            return this.Quantity * this.Price;

        }
    }
}
