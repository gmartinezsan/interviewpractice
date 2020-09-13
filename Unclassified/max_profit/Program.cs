using System;

namespace max_profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stockPrices = { 10, 7, 5, 8, 11, 9 };
            Console.WriteLine("MaxProfit is " + GetMaxProfit(stockPrices));
        }

        static int GetMaxProfit(int[] stockPrices)
        {
            if (stockPrices.Length < 2)
                throw new Exception("There are not enough values to get a profit value");

            int lowestbuyingvalue = stockPrices[0];
            int sellvalue = stockPrices[1];
            int maxProfit = sellvalue - lowestbuyingvalue;

            // get the lowest price
            for (int i = 1; i < stockPrices.Length; i++)
            {
                if (stockPrices[i] < lowestbuyingvalue)
                {
                    lowestbuyingvalue = stockPrices[i];
                }
                if (i < stockPrices.Length - 1)
                {
                    sellvalue = stockPrices[i + 1];
                    if ((sellvalue - lowestbuyingvalue) > maxProfit)
                    {
                        maxProfit = sellvalue - lowestbuyingvalue;
                    }
                }
            }
            return maxProfit;
        }
    }
}
