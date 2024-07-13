class Program
{
    static void Main(string[] args)
    {

    }
    public int[][] ModifiedMatrix(int[][] matrix)
    {
        for(int i = 0; i<matrix.Length; i++)
        {
            for(int j = 0; j<matrix[i].Length; j++)
            {
                if (matrix[i][j]==-1)
                {
                    var max = matrix[i][j];
                    for(int k = 0; k<matrix.Length; k++)
                    {
                        max=Math.Max(max, matrix[k][j]);
                    }
                    matrix[i][j]=max;
                }
            }
        }
        return matrix;
    }
}