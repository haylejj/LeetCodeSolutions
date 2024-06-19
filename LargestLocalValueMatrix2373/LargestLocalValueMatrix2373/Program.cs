class Program
{
    /*
     * You are given an n x n integer matrix grid.

    Generate an integer matrix maxLocal of size (n - 2) x (n - 2) such that:

    maxLocal[i][j] is equal to the largest value of the 3 x 3 matrix in grid centered around row i + 1 and column j + 1.
    In other words, we want to find the largest value in every contiguous 3 x 3 matrix in grid.

    Return the generated matrix.
     */
    static void Main(string[] args)
    {
        int[,] result = LargestLocal(new int[][] { new int[] { 9, 9, 8, 1 }, new int[] { 5, 6, 2, 6 }, new int[] { 8, 2, 6, 4 }, new int[] { 6, 2, 2, 2 } });
        for (int i = 0; i<result.GetLength(0); i++)
        {
            for (int j = 0; j<result.GetLength(1); j++)
            {
                Console.Write(result[i, j]+" ");
            }
            Console.WriteLine();
        }
    }
    public static int[,] LargestLocal(int[][] grid)
    {
        int n = grid.Length-2;
        int[,] result = new int[n,n];
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<n; j++)
            {
                result[i,j]=FindMax(grid, i, j);
            }
        }
        return result;
    }
    private static int FindMax(int[][] grid, int row, int col)
    {
        int max = int.MinValue;
        for (int i = row; i<row+3; i++)
        {
            for (int j = col; j<col+3; j++)
            {
                max=Math.Max(max, grid[i][j]);
            }
        }
        return max;
    }
}