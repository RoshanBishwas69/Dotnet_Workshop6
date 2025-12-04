using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating the sample bookings
            List<TourBooking> bookings = new List<TourBooking>()
            {
                new TourBooking("Roshan Bishwas Tharu", "Kathmandu", 12000, 5, false),
                new TourBooking("Rajaram Bishwas", "America", 8000, 3, false),
                new TourBooking("Ritik Bishwas ", "Paris", 50000, 7, true),
                new TourBooking("Uday Bishwas", "Lumbini", 15000, 6, false),
                new TourBooking("Sneha Bishwas", "London", 45000, 5, true)
            };

            // LINQ - Filter, Transform, Sort
            var tourSummaries = bookings
                .Where(t => t.Price > 10000 && t.DurationInDay > 4)
                .Select(t => new TourSummary(
                    t.CustomerName,
                    t.Destination,
                    t.IsInternational ? "International" : "Domestic",
                    t.Price))
                .OrderBy(t => t.Category)
                .ThenBy(t => t.Price)
                .ToList();

            // Now Displaying the results....
            Console.WriteLine("Filtered and Sorted Tour Bookings:\n");

            foreach (var tour in tourSummaries)
            {
                tour.Display();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}