class Program
{
    /*
     You are given a 0-indexed 2D integer matrix grid of size n * n with values in the range [1, n2]. 
     Each integer appears exactly once except a which appears twice and b which is missing. 
    The task is to find the repeating and missing numbers a and b.
    Return a 0-indexed integer array ans of size 2 where ans[0] equals to a and ans[1] equals to b.
     */
    static void Main(string[] args)
    {

    }
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int n = grid.Length;
        int i = 0;
        foreach (var item in grid)
        {
            foreach (var col in item)
            {
                if (dict.ContainsKey(col)) dict[col]++;
                else dict[col]=1;
            }
        }
        int[] result = new int[2];
        foreach(var item in dict)
            if(item.Value==2) result[0] = item.Key;
        
        for (i = 1; i <= n * n; i++)
        {
            if(!dict.ContainsKey(i))
            {
                result[1] = i;
                break;
            }
        }
        return result;
    }
}