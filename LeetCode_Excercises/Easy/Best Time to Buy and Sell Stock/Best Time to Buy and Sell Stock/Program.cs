using System;
using System.Linq;

namespace Best_Time_to_Buy_and_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] prices = new int[]
            {
               7,1,5,3,6,4
            };

            int result = MaxProfit(prices);

            Console.WriteLine(result);

        }

        public static int MaxProfit(int[] prices)
        {
            var minPrice = int.MaxValue;
            return prices.Max(price =>
            {
                minPrice = Math.Min(minPrice, price);
                return price - minPrice;
            });
        }
    }
}
