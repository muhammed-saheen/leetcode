public class Solution {
    public long PickGifts(int[] gifts, int k) {
        for(int i=0;i<k;i++){
            Array.Sort(gifts,(a,b)=>b-a);
            gifts[0] = (int)Math.Floor(Math.Sqrt(gifts[0]));
        }
        long sum = gifts.Select(x => (long)x).Sum();
        return sum;
    }
}