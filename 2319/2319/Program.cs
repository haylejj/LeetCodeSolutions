class Program
{
    static void Main(string[] args)
    {
        CheckXMatrix(new int[][] { new int[] { 2, 0, 0, 1 }, new int[] { 0, 3, 1, 0 }, new int[] { 0, 5, 2, 0 }, new int[] { 4, 0, 0, 2 } });
    }
    public static bool CheckXMatrix(int[][] grid)
    {
        for(int i = 0; i<grid.Length; i++)
        {
            for(int j = 0; j<grid[0].Length; j++)
            {
                var temp= grid[i][j];
                if (i==j && temp==0) return false;
                if (i!=j)
                {
                    if (i==grid.Length-j-1)
                    {
                        if (temp!=0) continue;
                        else return false;
                    }
                    else if(temp!=0) return false;
                }
            }
        }
        return true;
        //i=n-j-1;
    }
}