using System;
using Workshop6;

class Program
{
    static void Main()
    {
        NumberProcessor processor = new NumberProcessor();

        int[] sample = { 3, 4, 10, 12, 15, 22, 7, 8, 30 };

        Console.WriteLine("Only even numbers:");
        // Now passing a lambda that will returns true for even numbers...
        processor.ProcessNumbers(sample, n => n % 2 == 0);

        Console.WriteLine("\nOnly numbers greater than 10:");
        // passing a lambda that will returns true for the numbers > 10...
        processor.ProcessNumbers(sample, n => n > 10);
    }
}