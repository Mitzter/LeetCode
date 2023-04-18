namespace LeetCode_Excercises.Easy.RunningSum1dArray
{
    internal class RunningSum1dArray
    {

        //1480. Running Sum of 1d Array
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 1, 1, 1 };

            int[] runningArray = RunningSum(array);

            Console.WriteLine("[{0}]", string.Join(", ", runningArray));


        }
        public static int[] RunningSum(int[] nums)
        {
            int runningNum = 0;
            List<int> result = new List<int>();
            int counter = 0;
            foreach (int num in nums)
            {
                int nextNumber = nums.ElementAt(counter);

                runningNum = runningNum + nextNumber;

                result.Add(runningNum);
                counter++;
            }
            return result.ToArray();
        }
    }
}