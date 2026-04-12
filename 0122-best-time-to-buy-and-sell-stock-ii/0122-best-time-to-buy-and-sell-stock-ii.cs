public class Solution {
    public int MaxProfit(int[] prices) {
        int buyPrice = -1; 
        int totalProfit = 0;    
        int profit = 0;       

        for (int i = 0; i < prices.Length; i++) {
            if (i == prices.Length - 1){
                if (buyPrice >= 0 && buyPrice < prices[i]){
                    profit = prices[i] - buyPrice;
                    totalProfit += profit;
                }    
                break;
            }
            if (prices[i] < prices[i+1] && buyPrice == -1) {
                buyPrice = prices[i];
            }
            if (buyPrice < prices[i+1] && buyPrice >= 0) {
                profit = prices[i+1] - buyPrice;
                totalProfit += profit;
                buyPrice = -1;
            }
        }

        return totalProfit;
    }
}