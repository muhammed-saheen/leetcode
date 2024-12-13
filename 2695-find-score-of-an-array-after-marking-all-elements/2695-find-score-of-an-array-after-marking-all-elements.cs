using System;
using System.Collections.Generic;

public class Solution {
    public long FindScore(int[] nums) {
        long score = 0;
        int n = nums.Length;

        PriorityQueue<(int value, int index), (int,int)> pq = new PriorityQueue<(int value, int index), (int,int)>();

        for (int i = 0; i < n; i++) {
            pq.Enqueue((nums[i], i), (nums[i],i));
        }

        bool[] marked = new bool[n]; 
        while (pq.Count > 0) {
            var (minVal, index) = pq.Dequeue();

            if (marked[index]) {
                continue;
            }

            score += minVal;

            marked[index] = true;

            if (index - 1 >= 0 && !marked[index - 1]) {
                marked[index - 1] = true;
            }
            if (index + 1 < n && !marked[index + 1]) {
                marked[index + 1] = true;
            }
        }

        return score;
    }
}
