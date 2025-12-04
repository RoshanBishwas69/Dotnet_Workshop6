using System;

namespace Task2
{
    // creating delegate that accepts two integers and returns an integer
    public delegate int Calculate(int a, int b);

    public class CalculateOperations
    {
        // now writing the add method
        public int Add(int a, int b)
        {
            return a + b;
        }

        // now writing the subtract method
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}