using System;
using System.Collections.Generic;

namespace LastDigitToEnglish
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(DigitToWord(input));
            
        }
        static string DigitToWord(int num)
        {
            Dictionary<char, string> DigitWordPair = new Dictionary<char, string>();
            DigitWordPair.Add('0', "zero");
            DigitWordPair.Add('1', "one");
            DigitWordPair.Add('2', "two");
            DigitWordPair.Add('3', "three");
            DigitWordPair.Add('4', "four");
            DigitWordPair.Add('5', "five");
            DigitWordPair.Add('6', "six");
            DigitWordPair.Add('7', "seven");
            DigitWordPair.Add('8', "eight");
            DigitWordPair.Add('9', "nine");
            string word = num.ToString();
            return DigitWordPair[word[word.Length - 1]];

        }
    }
}
