public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int sum=0;
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[i].Length;j++){
                 if (grid[i][j] == 1) {
                    sum += 4;
                    if (i > 0 && grid[i - 1][j] == 1) {
                        sum -= 2;
                    }
                    if(j>0 && grid[i][j-1]==1){
                        sum=sum-2;
                    }  
                  
                }
            }
        }

        return sum;
    }
}