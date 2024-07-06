class Program
{
    /*
    There are n teams numbered from 0 to n - 1 in a tournament.
    Given a 0-indexed 2D boolean matrix grid of size n * n. 
    For all i, j that 0 <= i, j <= n - 1 and i != j team i is stronger than team j if grid[i][j] == 1, otherwise, team j is stronger than team i.
    Team a will be the champion of the tournament if there is no team b that is stronger than team a.
    Return the team that will be the champion of the tournament.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(FindChampion(new int[][] {new int[] { 0, 0, 1 }, new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 } }));
    }
    public static int FindChampion(int[][] grid)
    {
        int n = grid.Length;
        int count = 0;
        int winner=0;
        for(int i = 0; i<n; i++)
        {
            for(int j = 0; j<n; j++)
            {
                if(i==j) continue;
                if (grid[i][j]==1) count++;
            }
            if(count==n-1) winner= i;
            count = 0;
        }
        return winner;
    }
}