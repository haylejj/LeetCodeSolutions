class Program
{
    static void Main(string[] args)
    {
        MatrixReshape(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } }, 1, 4);
    }
    public static int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int row = mat.Length;
        int col = mat[0].Length;
        if (row*col!=r*c) return mat;
        int[][] result = new int[r][];
        int[] result2 = new int[row*col];
        int m = 0;
        for(int i = 0; i<row; i++)
        {
            for(int j=0; j<col; j++)
            {
                result2[m++]=mat[i][j];
            }
        }
        m= 0;
        for (int i = 0; i<r; i++)
        {
            result[i]=new int[c];
            for (int j = 0; j<c; j++)
            {
                result[i][j]=result2[m++];
            }
        }
        return result;

    }
}