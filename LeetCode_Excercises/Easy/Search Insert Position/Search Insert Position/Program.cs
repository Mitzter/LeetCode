using System;

namespace Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 7;

            int result = SearchInsert(nums, target);

            Console.WriteLine(result);
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int index = Array.IndexOf(nums, target);

            int resultIndex = 0;


            if(index == -1)
            {
                int previousNum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if(previousNum < target && nums[i] > target && i > 0)
                    {
                        resultIndex = Array.IndexOf(nums, nums[i]);
                        return resultIndex;
                    }
                    if(nums[nums.Length - 1] < target)
                    {
                        resultIndex = nums.Length;
                        return resultIndex;
                    }

                    previousNum = nums[i];
                }
            } 
            
            return index;
            


            
        }
    }
}
