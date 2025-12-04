using System;

namespace Workshop6
{
    public class NumberProcessor
    {
        public void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            if (numbers == null) return;

            foreach (var n in numbers)
            {
                if (condition(n))
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}