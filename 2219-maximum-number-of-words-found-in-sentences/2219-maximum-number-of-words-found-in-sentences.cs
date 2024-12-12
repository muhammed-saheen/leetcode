public class Solution {
    public int MostWordsFound(string[] sentences) {
        int biggest=0;
        for (int i=0 ;i<sentences.Length;i++){
             var len=sentences[i].Split(" ").Length;
             if (len>biggest){
                biggest=len;
            }
        }
        return biggest;
    }
}