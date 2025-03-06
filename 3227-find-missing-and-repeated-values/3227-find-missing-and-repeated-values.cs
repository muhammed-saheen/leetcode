using System;
using System.Collections.Generic;

public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        int n = grid.Length;
        int repeated = -1, missing = -1;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (frequency.ContainsKey(grid[i][j])) {
                    frequency[grid[i][j]]++;
                } else {
                    frequency[grid[i][j]] = 1;
                }
            }
        }

        for (int num = 1; num <= n * n; num++) {
            if (frequency.ContainsKey(num)) {
                if (frequency[num] > 1) {
                    repeated = num;
                }
            } else {
                missing = num;
            }
        }

        return new int[] { repeated, missing };
    }
}
