public class Solution {
    public int[] PlusOne(int[] digits) {
        string item = string.Join("", digits);

        BigInteger number = BigInteger.Parse(item) + 1;

        string string_final = number.ToString();

        int[] output = string_final.Select(c => int.Parse(c.ToString())).ToArray();

        return output;
    }
}