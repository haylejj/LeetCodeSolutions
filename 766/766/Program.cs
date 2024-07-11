class Program
{
    static void Main(string[] args)
    {

    }
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        bool result = false;
        for (int i = 1; i<matrix.Length; i++)
        {
            for(int j = 1; j<matrix[i].Length; j++)
            {
                if (matrix[i][j] != matrix[i-1][j-1]) return false;
            }
        }
        return true;
    }
}