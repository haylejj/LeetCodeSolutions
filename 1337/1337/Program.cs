class Program
{
    /*
     You are given an m x n binary matrix mat of 1's (representing soldiers) and 0's (representing civilians). 
     The soldiers are positioned in front of the civilians. That is, all the 1's will appear to the left of all the 0's in each row.

    A row i is weaker than a row j if one of the following is true:

    The number of soldiers in row i is less than the number of soldiers in row j.
    Both rows have the same number of soldiers and i < j.
    Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(KWeakestRows(new int[][] {new int[] {1,1,0,0,0}, new int[] { 1, 1, 1, 1, 0 }, new int[] { 1, 0, 0, 0, 0 }, new int[] { 1, 1, 0, 0, 0 }, new int[] { 1, 1, 1, 1, 1 } },3));
    }
    public static int[] KWeakestRows(int[][] mat, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int count = 0;
        for (int i = 0; i<mat.Length; i++)
        {
            var length = mat[i].Length;
            for (int j = 0; j<length; j++)
            {
                if (mat[i][j] == 1)
                    count++;
                else break;
            }
            
                dict.Add(i, count);
            count = 0;
        }
        return dict.OrderBy(x=> x.Value).Take(k).Select(x => x.Key).ToArray();

    }
}