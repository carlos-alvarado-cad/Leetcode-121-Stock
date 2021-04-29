using System;
using System.Linq;

namespace LC121Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 2, 6, 4 };
            Console.WriteLine(MaxProfit(prices));
        }

        public static int MaxProfit(int[] prices)
        {
            // account for null/empty
            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] >= profit)
                    {
                        profit = prices[j] - prices[i];
                    }
                }
            }
            return profit;
        }
    }
}
