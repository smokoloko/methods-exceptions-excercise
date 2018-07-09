using System;
using System.Linq;

namespace NumberOfOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(x => short.Parse(x)).ToArray<short>();
            short elementNeeded = short.Parse(Console.ReadLine());
            Console.WriteLine(OccurenceInArray(numbers, elementNeeded));
        }
        static int OccurenceInArray(short[] numbers, short elementNeeded)
        {
            short sum = 0;
            while (true)
            {
                short index = (short)Array.IndexOf(numbers, elementNeeded);
                if (index == -1)
                {
                    break;
                }
                else
                {
                    sum++;
                    numbers[index] = (short)(elementNeeded + 1);
                }
            }
            return sum;
        } 
    }
}
