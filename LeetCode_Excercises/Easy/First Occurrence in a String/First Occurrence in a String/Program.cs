using System;

namespace First_Occurrence_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {

            string haystack = Console.ReadLine();
            string needle = Console.ReadLine();

            Console.WriteLine(StrStr(haystack, needle));
        }

        public static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
