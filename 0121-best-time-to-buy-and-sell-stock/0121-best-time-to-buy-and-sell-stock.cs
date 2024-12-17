public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0) return 0; 
        int lowest = prices[0];
        int maxprofit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < lowest)
            {
                lowest = prices[i];
            }
            int profit = prices[i] - lowest;
            if (profit > maxprofit)
            {
                maxprofit = profit; 
            }
        }
        return maxprofit;
    }
}
