using System;

namespace PrintName
{
    class PrintNameMethod
    {
        static void Main()
        {
            PrintName("Teo");
            PrintName(null);
        }
        static void PrintName(string name)
        {
            if(name == null)
            {
                Console.WriteLine("Hello guest");
            }
            else
            {
                Console.WriteLine($"Hello {name}");
            }
        }
    }
}
