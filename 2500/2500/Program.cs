class Program
{
    /*
     You are given an m x n matrix grid consisting of positive integers.

    Perform the following operation until grid becomes empty:

    Delete the element with the greatest value from each row. If multiple such elements exist, delete any of them.
    Add the maximum of deleted elements to the answer.
    Note that the number of columns decreases by one after each operation.

    Return the answer after performing the operations described above.
     */
    static void Main(string[] args)
    {
        int[][] grid=new int[][] {new int[]{1,2,3},new int[]{3,3,1}};
        Console.WriteLine(DeleteGreatestValue(grid));
    }
    public static int DeleteGreatestValue(int[][] grid)
    {
        //[1,2,4],[3,3,1]
        // 1,2,4
        // 1,3,3
        int sum = 0;
        foreach (var item in grid)
        {
            Array.Sort(item);
        }
        for (int j = grid[0].Length-1; j >=0; j--)
        {
            int maxTemp = 0;
            for (int i = grid.Length - 1; i >= 0; i--)
            {
                maxTemp = Math.Max(maxTemp, grid[i][j]);
            }
            sum += maxTemp;
        }
        return sum;
    }
}