using System;
using System.Linq;

namespace Kitty
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = Console.ReadLine().ToCharArray();
            var jumps = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int foodCount = 0;
            int locksCount = 0;
            int soulsCount = 0;
            int curPos = 0;
            int newPos = 0;
            if (chars[0] == '@')
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: 0");
            }
            else
            {
                for (int i = 0; i < jumps.Length; i++)
                {

                    if (jumps[i] < 0)
                    {
                        int moves = curPos + jumps[i];
                        newPos = (moves >= 0) ? Math.Abs(moves)%chars.Length : chars.Length - Math.Abs(moves) % chars.Length;
                    }
                    else
                    {
                        newPos = (curPos + jumps[i]) % chars.Length;
                    }
                    Console.WriteLine(newPos);
                    curPos = newPos;

                }
            }
        }
    }
}
