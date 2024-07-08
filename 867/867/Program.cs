class Program
{
    static void Main(string[] args)
    {

    }
    public int[][] Transpose(int[][] matrix)
    {
        int[][] result = new int[matrix[0].Length][];
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        for (int i = 0; i < cols; i++)
        {
            result[i] = new int[rows];
            for (int j = 0; j < rows; j++)
                result[i][j] = matrix[j][i];
        }
        return result;
    }
}