public class Solution {
    public string LongestWord(string[] words) {
       Array.Sort(words);
       var items = new HashSet<string>{""};
       var biggest="" ;
       foreach (string x in words){
        if (items.Contains(x.Substring(0, x.Length - 1))) {
            items.Add(x);
            if(x.Length>biggest.Length){
                biggest=x;
            }
          }
       }
       return biggest;
    }
}