class Program
{
    static void Main(string[] args)
    {

    }
    public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
    {
        List<List<int>> result = new List<List<int>>();
        for (int i = 0; i<rows; i++)
        {
            for (int j = 0; j<cols; j++)
            {
                result.Add(new List<int> { i, j });
            }
        }
        result.Sort((a, b) => {
            int distA = Math.Abs(a[0] - rCenter) + Math.Abs(a[1] - cCenter);
            int distB = Math.Abs(b[0] - rCenter) + Math.Abs(b[1] - cCenter);
            return distA - distB;
        });
        return result.Select(x => x.ToArray()).ToArray();
    }
}