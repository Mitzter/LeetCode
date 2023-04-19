using System.Text;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            bool result = IsPalindrome(input);

            Console.WriteLine(result);
        }

        public static bool IsPalindrome(int x)
        {
            if( x < 0)
            {
                return false;
            };

            char[] arr = x.ToString().ToCharArray();
            List<char> list = new List<char>();
            List<char> reverse = new List<char>();

            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reverse.Add(arr[i]);
            }

            bool status = true;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (list[i] == reverse[i])
                {
                    continue;
                }
                else
                {
                    status = false;
                }

            }
            

            return status;
           

            
           
            


        }
    }
}