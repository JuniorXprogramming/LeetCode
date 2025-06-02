# Problem Name: Best Time to Buy and Sell Stock

**Difficulty:** Easy

## Problem Description
You are given an array `prices` where `prices[i]` is the price of a given stock on the `i`th day.

Find the maximum profit you can achieve by buying on one day and selling on another later day.  
If no profit can be made, return 0.

---

## Approach / Solution

The idea is to track the minimum price seen so far and calculate the profit if sold on the current day.

### Steps:
1. Initialize `minPrice` as the first price in the array.
2. Iterate through the price array starting from the second day:
   - Update `minPrice` to the smallest price seen so far.
   - Calculate the current profit by subtracting `minPrice` from the current price.
   - Update `maxProfit` if the current profit is greater than the previously recorded maximum.
3. Return `maxProfit`.

---

## Time Complexity
- **O(n)** where `n` is the number of days/prices.

## Space Complexity
- **O(1)** constant space.

---

## Code (C#)

```csharp
using System;

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
