using System;

namespace TravelCompany
{
    public class TourBooking
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDay { get; set; }
        public bool IsInternational { get; set; }

        public TourBooking(string customerName, string destination, double price, int durationInDay, bool isInternational)
        {
            CustomerName = customerName;
            Destination = destination;
            Price = price;
            DurationInDay = durationInDay;
            IsInternational = isInternational;
        }
    }
}