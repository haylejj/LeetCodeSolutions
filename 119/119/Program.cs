class Program
{
    static void Main(string[] args)
    {

    }
    public IList<int> GetRow(int rowIndex)
    {
        var array = makePascalTriangle();
        return array[rowIndex];
    }
    private IList<IList<int>> makePascalTriangle()
    {
        int[][] pascalTriangle = new int[34][];
        for(int i=0;i<pascalTriangle.Length; i++)
        {
            pascalTriangle[i]=new int[i+1];
            pascalTriangle[i][0]=1;
            pascalTriangle[i][i]=1;
            for(int j = 1; j<i; j++)
                pascalTriangle[i][j]=pascalTriangle[i-1][j]+pascalTriangle[i-1][j-1];
        }
        return pascalTriangle;
    }
}