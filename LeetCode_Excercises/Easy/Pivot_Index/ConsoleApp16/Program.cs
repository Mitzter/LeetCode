using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = new int[] { 1, 7, 3, 6, 5, 6 };


            int pivotIndex = PivotIndex(input);

            Console.WriteLine(pivotIndex);

            
        }

        public static int PivotIndex(int[] nums)
        {
            
            List<int> inputList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                inputList.Add(nums[i]);
            }

            int currentIndex = 0;
            int leftSum;
            int rightSum;
            int leftmostIndex = 0;

            for (int index = 0; index < inputList.Count; index++)
            {
                leftSum = 0;
                rightSum = 0;

                for (int i = 0; i < index; i++)
                {
                    leftSum += inputList[i];
                }

                for (int j = inputList.Count - 1; j > index; j--)
                {
                    rightSum += inputList[j];
                }

                currentIndex++;

                if (leftSum == rightSum)
                {
                    leftmostIndex = index;
                    break;
                }

                else if(leftSum != rightSum)
                {
                    leftmostIndex = -1;
                    
                }

               
            }
            return leftmostIndex;
        }
    }
}
