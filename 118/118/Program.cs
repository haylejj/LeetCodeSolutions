class Program
{
    /*
     Given an integer numRows, return the first numRows of Pascal's triangle.

    In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

    1                                      
    1   1   
    1   2   1
    1   3   3   1
    1   4   6   4   1
     */
    static void Main(string[] args)
    {

    }
    public IList<IList<int>> Generate(int numRows)
    {
        int [][] result = new int[numRows][];
        for(int i = 0; i<numRows; i++)
        {
            result[i]=new int[i+1];
            result[i][0]=1;
            result[i][i]=1;
            for(int k = 1; k<i; k++)
            {
                result[i][k]=result[i-1][k-1]+result[i-1][k];
            }
        }
        return result;
    }
}