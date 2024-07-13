class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindColumnWidth(new int[][] {new int[] {-15,1,3}, new int[] { 15,7,12 }, new int[] { 5,6,-2 } }));
    }
    public static int[] FindColumnWidth(int[][] grid)
    {
        List<int> result = new List<int>();
        for(int i = 0; i<grid[0].Length; i++)
        {
            var maxLength = int.MinValue;
            for(int j = 0; j<grid.Length; j++)
            {
                string temp = grid[j][i].ToString();
                maxLength=Math.Max(maxLength, temp.Length);
            }
            result.Add(maxLength);
        }
        return result.ToArray();

    }
}