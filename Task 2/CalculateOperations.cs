using System;

namespace Task2
{
    public delegate int Calculate(int a, int b);

    public class CalculateOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}