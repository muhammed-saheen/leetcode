public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        bool [] arr= new bool[right+1];
        arr[0] = arr[1] = true;
        for(int i = 2; i * i <= right; i++) {
                if (!arr[i]) { 
                    for(int j = i * 2; j <= right; j += i) { 
                        arr[j] = true; 
                    }
                }
            }

        List<int> primes = new List<int>();
        for(int i=left;i<=right;i++){
            if(!arr[i]){
                 primes.Add(i);
            }
        }

        int[] a = new int[2] { -1, -1 }; 
        int min = int.MaxValue;
        if(primes.Count<2){
            return new int[] {-1,-1};
        }
        for(int i=1;i<primes.Count;i++){
          int diff = primes[i] - primes[i - 1];
            if (diff < min) {
                min = diff;
                a[0] = primes[i - 1];
                a[1] = primes[i];
            }
        }
       return a;
    }
}