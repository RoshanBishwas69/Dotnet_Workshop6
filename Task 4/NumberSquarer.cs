using System;
using System.Collections.Generic;
using System.Linq;

namespace Workshop6
{
    public class NumberSquarer
    {
        public void SquareNumbers()
        {
            // making a simple list of integers
            List<int> nums = new List<int> { 1, 2, 3, 4, 5 };

            // using LINQ to square each number
            var squared = nums.Select(n => n * n);

            Console.WriteLine("Squared Numbers:");
            foreach (var n in squared)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
        }
    }
}