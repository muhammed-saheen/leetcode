public class Solution {
    public int FindCenter(int[][] edges) {
            if(edges[0][0]==edges[1][0]){
                return edges[0][0];
            }
            else if(edges[0][0]==edges[1][1]){
                return edges[0][0];
            }
            return edges[0][1];
    }
}