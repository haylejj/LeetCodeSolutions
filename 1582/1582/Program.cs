class Program
{
    static void Main(string[] args)
    {

    }
    public int NumSpecial(int[][] mat)
    {
        int count = 0;
        for(int i = 0; i<mat.Length; i++)
        {
            for(int j = 0; j<mat[i].Length; j++)
            {
                if (mat[i][j]==1 && IsSpecial(mat, i, j)) count++;
            }
        }
        return count;
    }
    private bool IsSpecial(int[][] mat,int i,int j)
    {
        for(int k = 0; k<mat[i].Length; k++)
        {
            if (mat[i][k]==1 && k!=j) return false;
        }
        for(int k = 0; k<mat.Length; k++)
        {
            if (mat[k][j]==1 && k!=i) return false;
        }
        return true;
    }
}