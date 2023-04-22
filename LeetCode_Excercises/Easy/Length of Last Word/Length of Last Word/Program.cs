using System;

namespace Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int count = LengthOfLastWord(input);


            Console.WriteLine(count);

        }

        public static int LengthOfLastWord(string s)
        {
            string[] splitString = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int lastWordLetterCount = splitString[splitString.Length - 1].Length;

            return lastWordLetterCount;

        }
    }
}
