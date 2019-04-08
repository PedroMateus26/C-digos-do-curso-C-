using System;
using ComposicaoEnumExercicio.Entities;
using ComposicaoEnumExercicio.Entities.Enums;

namespace ComposicaoEnumExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data");                                 //Primeira etapa, dados e infomações do cliente
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Email: ");
            String email = Console.ReadLine();
            Console.Write("Birth date (mm/dd/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data");                                  //Declaração do estatus e do objeto order
            Console.Write("Status: ");
            OrderStatus status =Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many itens to order: ");
            int n = int.Parse(Console.ReadLine());
            DateTime momment = DateTime.Now;
            Order order = new Order(momment, status, client);

            for(int i =1; i<=n; i++)
            {
                Console.WriteLine($"Enter with product {i}");
                Console.Write("Product Name: ");
                String nproduct = Console.ReadLine();
                Console.Write("Enter with the price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Enter with the quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(nproduct, price);
                OrderItem orderitem = new OrderItem(quantity, price, product);
                order.AddItem(orderitem);

            }

            Console.WriteLine("Order Sumary:");
            Console.WriteLine(order.ToString()); 


        }
    }
}
