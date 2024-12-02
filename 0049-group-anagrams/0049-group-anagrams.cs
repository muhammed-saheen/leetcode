public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
    Dictionary<String,List<String>> fullarray = new  Dictionary<String,List<String>>();
    foreach(string str in strs){
        var sorted =new String(str.OrderBy(x=>x).ToArray());
        if (!fullarray.ContainsKey(sorted)){
            fullarray[sorted]=new List<String>();
        }
        fullarray[sorted].Add(str);
    }
        return fullarray.Values.Cast<IList<string>>().ToList();  
    }
}