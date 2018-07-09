using System;
using System.Linq;

namespace GetMax
{
    class GetMaxMethod
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            Console.WriteLine(GetMax(GetMax(numbers[1],numbers[0]),numbers[2]));
        }
        static int GetMax(int a, int b)
        {
             return Math.Max(a,b);
        } 
    }
}
