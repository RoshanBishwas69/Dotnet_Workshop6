using System;
using Task2;

class Program
{
    static void Main()
    {
\        CalculateOperations calc = new CalculateOperations();

        Calculate addDelegate = calc.Add;
        Calculate subDelegate = calc.Subtract;

        Console.WriteLine("----- Integer Operations -----");
        Console.WriteLine("Add(10, 5) = " + addDelegate(10, 5));
        Console.WriteLine("Subtract(10, 5) = " + subDelegate(10, 5));


\        DiscountOperations disc = new DiscountOperations();
        double price = 1000;

        Console.WriteLine("\n----- Discount Calculations -----");
        Console.WriteLine("Festival Discount: " + disc.CalculateFinalPrice(price, disc.FestivalDiscount));
        Console.WriteLine("Seasonal Discount: " + disc.CalculateFinalPrice(price, disc.SeasonalDiscount));
        Console.WriteLine("No Discount: " + disc.CalculateFinalPrice(price, disc.NoDiscount));

        // Lambda 30% Discount 
        Console.WriteLine("Lambda 30% Discount: " + disc.CalculateFinalPrice(price, p => p * 0.70));
    }
}