class Program
{
    /*
     Given a m x n matrix grid which is sorted in non-increasing order both row-wise and column-wise, return the number of negative numbers in grid.
     */
    static void Main(string[] args)
    {

    }
    public int CountNegatives(int[][] grid)
    {
        int count = 0;
        for(int i = 0; i<grid.Length; i++)
        {
            for(int j = 0; j<grid[i].Length; j++)
            {
                if (grid[i][j]<0) count++;
            }
        }
        return count;
    }
}