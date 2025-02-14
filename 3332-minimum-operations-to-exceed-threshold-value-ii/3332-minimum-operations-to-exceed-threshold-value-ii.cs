using System;
using System.Collections.Generic;

public class Solution {
    public int MinOperations(int[] nums, int k) {
        PriorityQueue<long, long> que = new PriorityQueue<long, long>();

        foreach (int num in nums) {
            que.Enqueue(num, num);
        }

        int count = 0;

        while (que.Count > 1 && que.Peek() < k) {
            count++;
            long n1 = que.Dequeue();
            long n2 = que.Dequeue();
            long temp = (n1 * 2) + n2; 
            que.Enqueue(temp, temp);
        }

        return que.Peek() >= k ? count : -1;
    }
}
