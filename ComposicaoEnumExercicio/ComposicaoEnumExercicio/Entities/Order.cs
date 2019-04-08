using System;
using System.Collections.Generic;
using System.Text;
using ComposicaoEnumExercicio.Entities;
using ComposicaoEnumExercicio.Entities.Enums;

namespace ComposicaoEnumExercicio
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            this.Moment = moment;
            this.OrderStatus = orderStatus;
            this.Client = client;

        }

        public void AddItem(OrderItem orderItem)
        {
            this.OrderItem.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderitem)
        {
            this.OrderItem.Remove(orderitem);
        }

        public double Total()
        {
            double sum=0;
            foreach (OrderItem c in OrderItem) sum += c.SubTotal();
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("Order momment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order Status: ");
            sb.AppendLine(OrderStatus.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.Date);
            sb.Append(")");
            sb.Append(" - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order Intens");
            
            foreach(OrderItem order in OrderItem)
            {
                sb.Append(order.Product.Name);
                sb.Append(", ");
                sb.Append(order.Price);
                sb.Append(", ");
                sb.Append("Quantity: ");
                sb.Append(order.Quantity);
                sb.Append(", ");
                sb.Append("Subtotal: $");
                sb.AppendLine(order.SubTotal().ToString());
                

            }

            sb.Append("Total: ");
            sb.AppendLine(Total().ToString());

            return sb.ToString();
        }
       

    }
}

