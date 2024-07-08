class Program
{
    static void Main(string[] args)
    {

    }
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var listMax=new List<int>();
        var listMin=new List<int>();

        for (int i=0;i<matrix.Length;i++)
        {
            listMin.Add(matrix[i].Min());
        }
        for(int i = 0; i<matrix[0].Length; i++)
        {
            var max = int.MinValue;
            for(int j = 0; j<matrix.Length; j++)
            {
                max=Math.Max(max,matrix[j][i]);
            }
            listMax.Add(max);
        }
        return listMin.Intersect(listMax).ToList();
    }
}