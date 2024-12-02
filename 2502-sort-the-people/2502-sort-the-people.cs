public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        var list = new List<(String name,int height)>();
        int i=0;
        foreach(String name in names){
        list.Add((name,heights[i])) ;
        i++;
        }
        return list.OrderByDescending(x=>x.height).Select(y=>y.name).ToArray();
       
    }
}