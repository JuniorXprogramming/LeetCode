using System;
using System.Collections.Generic;

public class MaxProfitSolution {
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = prices.Length > 0 ? prices[0] : 0;

        if (prices.Length == 0)
        {
            return maxProfit;
        }

        for (int i = 1; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            int profit = prices[i] - minPrice;
            maxProfit = Math.Max(maxProfit, profit);
        }

        return maxProfit;
    }
}
