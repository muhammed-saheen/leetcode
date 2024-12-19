public class Solution {
    public string LargestNumber(int[] nums) {
        string[] strNums = nums.Select(num => num.ToString()).ToArray();

        Array.Sort(strNums, (x, y) => (y + x).CompareTo(x + y));

        if (strNums[0] == "0") {
            return "0";
        }

        return string.Join("", strNums);
    }
}