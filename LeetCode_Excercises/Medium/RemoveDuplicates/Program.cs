using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 5, 7, 7, 8, 8, 10 };

            int target = 8;

            Console.WriteLine("[{0}]", string.Join(", ", SearchRange(input, target)));
            
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            List<int> coordinates = new List<int>(2);

            coordinates.Add(Array.IndexOf(nums,target));
            coordinates.Add(Array.LastIndexOf(nums, target));


            return coordinates.ToArray();
        }
    }
}
