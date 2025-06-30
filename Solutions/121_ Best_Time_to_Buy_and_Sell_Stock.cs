//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

public class Best_Time_to_Buy_and_Sell_Stock
{
    public int MaxProfit(int[] prices)
    {
        var smallest = prices[0];
        var bestProfit = 0;

        for (var pos = 0; pos < prices.Length; pos++)
        {
            if (prices[pos] < smallest)
            {
                smallest = prices[pos];
            }

            var profit = prices[pos] - smallest;
            if (profit > bestProfit)
            {
                bestProfit = profit;
            }
        }
        return bestProfit;
    }
}