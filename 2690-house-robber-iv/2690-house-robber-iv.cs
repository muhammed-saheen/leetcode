using System;

public class Solution {
    public int MinCapability(int[] nums, int k) {
        int left = int.MaxValue, right = int.MinValue;

        foreach (int num in nums) {
            left = Math.Min(left, num);
            right = Math.Max(right, num);
        }

        while (left < right) {
            int mid = left + (right - left) / 2;
            if (CanSteal(nums, k, mid)) {
                right = mid; // Try smaller capability
            } else {
                left = mid + 1; // Increase capability
            }
        }

        return left;
    }

    private bool CanSteal(int[] nums, int k, int cap) {
        int count = 0;
        int i = 0;
        
        while (i < nums.Length) {
            if (nums[i] <= cap) {
                count++;
                i++; // Skip the adjacent house
            }
            i++;
        }
        
        return count >= k;
    }
}
