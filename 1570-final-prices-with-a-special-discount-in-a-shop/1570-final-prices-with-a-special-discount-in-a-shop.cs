public class Solution {
    public int[] FinalPrices(int[] prices) {
      List<int> answer = new List<int>();
      for(int i=0;i<prices.Length;i++){
        int discount =0;
        for(int j=i+1;j<prices.Length;j++){
            if(prices[i]>=prices[j]){
                discount=prices[j];
                break;
            }
        }
        answer.Add(prices[i]-discount);
    
      } 
      return answer.ToArray(); 
    }
}