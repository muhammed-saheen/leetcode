using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int CountPoints(string rings) {
        var rods = new Dictionary<char, HashSet<char>>();
        
        for (int i = 0; i < rings.Length; i += 2) {
            char color = rings[i];   
            char rod = rings[i + 1]; 
            
            if (!rods.ContainsKey(rod)) {
                rods[rod] = new HashSet<char>();
            }
            
          rods[rod].Add(color);
        }

        int count = 0;
        foreach (var rod in rods.Values) {
            if (rod.Count == 3) { 
                count++;
            }
        }

        return count;
    }
}
