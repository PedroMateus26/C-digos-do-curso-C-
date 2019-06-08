using System;
using System.Globalization;
using ProblemaComMaisCamadas.Entities;
using ProblemaComMaisCamadas.Services;

namespace ProblemaComMaisCamadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel");
            Console.WriteLine("Car model");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyy) hh:mm - ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyy) hh:mm - ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per hour:");
            double hour = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter price per day:");
            double day = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.PrcessInvoice(carRental);
            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
