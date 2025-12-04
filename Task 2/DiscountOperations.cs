using System;

namespace Task2
{
    public delegate double DiscountStrategy(double price);

    public class DiscountOperations
    {
        public double FestivalDiscount(double price)
        {
            return price * 0.80;
        }

      
        public double SeasonalDiscount(double price)
        {
            return price * 0.90;
        }

        // no discount applied
        public double NoDiscount(double price)
        {
            return price;
        }

        
        public double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            return strategy(originalPrice);
        }
    }
}