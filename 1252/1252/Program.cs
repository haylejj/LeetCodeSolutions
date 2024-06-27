class Program
{
    /*
     There is an m x n matrix that is initialized to all 0's. There is also a 2D array indices where each indices[i] = [ri, ci] represents a 0-indexed location to perform some increment operations on the matrix.

    For each location indices[i], do both of the following:

    Increment all the cells on row ri.
    Increment all the cells on column ci.
    Given m, n, and indices, return the number of odd-valued cells in the matrix after applying the increment to all locations in indices.
     */
    static void Main(string[] args)
    {

    }
    public int OddCells(int m, int n, int[][] indices)
    {
        //indices = [[0,1],[1,1]]
        int[,] result=new int[m,n];
        for(int i = 0; i<indices.Length; i++)
        {
            for(int j = 0; j<n; j++)
            {
                result[indices[i][0], j]++;
            }
            for(int k = 0; k<m; k++)
            {
                result[k, indices[i][1]]++;
            }
        }
        int count = 0;
        for(int i = 0; i<m; i++)
        {
            for(int j = 0; j<n; j++)
            {
                if(result[i,j]%2!=0)
                {
                    count++;
                }
            }
        }
        return count;
    }
}