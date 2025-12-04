using System;

namespace TravelCompany
{
    public class TourSummary
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public TourSummary(string customerName, string destination, string category, double price)
        {
            CustomerName = customerName;
            Destination = destination;
            Category = category;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Price: Rs. {Price}");
            Console.WriteLine("------------------------------");
        }
    }
}