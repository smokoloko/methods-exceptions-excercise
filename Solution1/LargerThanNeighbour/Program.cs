using System;
using System.Collections.Generic;
using System.Linq;

namespace LargerThanNeighbour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            Console.WriteLine(LargerThanNeighbour(numbers));
        }
        static int LargerThanNeighbour(int[] numbers)
        {
            int validNumbers = 0;
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                values.Add(i, numbers[i]);
            }
            foreach(KeyValuePair<int,int> number in values)
            {
                try
                {
                    if (number.Value > values[number.Key - 1] && number.Value > values[number.Key + 1])
                    {
                        validNumbers++;
                    }
                }
                catch(KeyNotFoundException)
                {
                    continue;
                }
            }
            return validNumbers;
        }
    }
}
