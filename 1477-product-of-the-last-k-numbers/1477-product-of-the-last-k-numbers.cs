public class ProductOfNumbers {
    List<int> ls ;
    public ProductOfNumbers() {
    ls=new List<int>();
    }
    
    public void Add(int num) {
        ls.Add(num);
    }
    
    public int GetProduct(int k) {
        int product =1;
        int i=ls.Count()-1;
        int count =0;
        while(count<k){
        product =product * ls[i];
        count++;
        i--;
        }
        return product;
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */