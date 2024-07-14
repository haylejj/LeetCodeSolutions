class Program
{
    static void Main(string[] args)
    {

    }
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
       Queue<int> q = new Queue<int>();
        int row = grid.Length;
        int col = grid[0].Length;
        for(int m = 0; m<k*grid[0].Length; m++)
        {
            for(int i = 0; i<row; i++)
            {
                for(int j = 0; j<col; j++)
                {
                    var temp = grid[i][j+1%col];
                    grid[i][j+1%col]=grid[i][j];
                    grid[i][j]=temp;
                }
            }
            for(int i = 0; i<row; i++)
            {
                var temp = grid[i+1%row][0];
                grid[i+1%row][0]=grid[i][0];
                grid[i][0]=temp;
            }
        }
    }
}