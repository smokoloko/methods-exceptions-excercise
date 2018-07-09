using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace appearance_count_dictionary_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            string numbers = Console.ReadLine();
            string numberNeeded = Console.ReadLine();
            Console.WriteLine(Regex.Matches(numbers, @"(^|\s)" + numberNeeded + @"($|\s)").Count);
        }
    }
}
