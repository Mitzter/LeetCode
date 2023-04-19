using System;
using System.Collections.Generic;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;


            int[] result = TwoSum(nums, target);

            Console.WriteLine("[{0}]", string.Join(", ", result));
        
        }

        public static int[] TwoSum(int[] nums, int target)
        {

            List<int> result = new List<int>();
            int currentIndex = 0;
            foreach (int num in nums)
            {
                currentIndex++;
                for (int i = currentIndex; i <= nums.Length - 1; i++)
                {
                    if (num + nums[i] == target)
                    {
                        result.Add(Array.FindIndex(nums, x => x.Equals(num)));
                        result.Add(Array.FindLastIndex(nums, x => x.Equals(nums[i])));
                        break;
                    }
                }


            }

            return result.ToArray();



        }
    }
}
