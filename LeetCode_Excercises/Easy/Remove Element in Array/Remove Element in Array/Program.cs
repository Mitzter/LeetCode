using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 2, 3 };
            int valueToRemove = 3;

            int k = RemoveElement(nums, valueToRemove);

            Console.WriteLine(k);
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int result = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if(nums[i] != val)
            //    {
            //        nums[result] = nums[i];
            //        result++;
            //    }
            //}

            nums = nums.Where(x => x != val).ToArray();

            result = nums.Length;
            return result;
            
        }
    }
}
