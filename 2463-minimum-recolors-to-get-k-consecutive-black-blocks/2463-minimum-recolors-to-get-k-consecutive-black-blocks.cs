public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int minRecolors = 0;
        int whiteCount = 0;

        for (int i = 0; i < k; i++) {
            if (blocks[i] == 'W') {
                whiteCount++;
            }
        }

        minRecolors = whiteCount; 

        for (int i = k; i < blocks.Length; i++) {
            if (blocks[i - k] == 'W') { 
                whiteCount--;
            }
            if (blocks[i] == 'W') { 
                whiteCount++;
            }

            minRecolors = Math.Min(minRecolors,whiteCount);
        }

        return minRecolors;
    }
}
