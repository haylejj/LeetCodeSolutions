class Program
{
    /*
     Given a m x n binary matrix mat, find the 0-indexed position of the row that contains the maximum count of ones, and the number of ones in that row.

    In case there are multiple rows that have the maximum count of ones, the row with the smallest row number should be selected.

    Return an array containing the index of the row, and the number of ones in it.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(RowAndMaximumOnes(new int[][] { new int[] {0,1 }, new int[] { 1,0 } }));
    }
    public static  int[] RowAndMaximumOnes(int[][] mat)
    {
        //[0,1],[1,0]
        //0,1
        //1,0
        int[] result= new int[2];
        int max = 0;
        for(int i = 0; i<mat.Length; i++)
        {
            var count= mat[i].Count(x=>x==1);
            if (count>max )
            {
                result[0]=i;
                result[1]=count;
                max = count;
            }
        }
        return result;
    }
}