class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(NearestValidPoint(2,2,new int[][] { new int[] {5,4}, new int[] { 3, 4 }, new int[] { 1,3}, new int[] { 3,2 }, new int[] { 1,7 }, new int[] { 4,2 } }));
    }
    public static int NearestValidPoint(int x, int y, int[][] points)
    {
        List<List<int>> list = new List<List<int>>();
        foreach (var row in points)
        {
            if(row[0] == x || row[1] == y)
            {
                list.Add(new List<int> { row[0], row[1] });
            }
        }
        if (list.Count == 0) return -1;
        int minDistance = int.MaxValue;
        int index = 0;
        for(int i = 0; i<list.Count; i++)
        {
            var tempDistance= Math.Abs(x - list[i][0]) + Math.Abs(y - list[i][1]);
            if (tempDistance < minDistance)
            {
                minDistance = tempDistance;
                index = i;
            }
        }
       
        return Array.FindIndex(points, x => x[0] == list[index][0] && x[1] == list[index][1]);
    }
}