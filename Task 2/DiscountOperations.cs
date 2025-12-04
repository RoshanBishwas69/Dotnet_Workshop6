using System;

namespace Task2
{
    // creating delegate that takes a price and returns discounted price
    public delegate double DiscountStrategy(double price);

    public class DiscountOperations
    {
        // now giving 20% discount
        public double FestivalDiscount(double price)
        {
            return price * 0.80;
        }

        // now giving 10% discount
        public double SeasonalDiscount(double price)
        {
            return price * 0.90;
        }

        // no discount applied
        public double NoDiscount(double price)
        {
            return price;
        }

        // now calculating final price using delegate strategy
        public double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }
    }
}