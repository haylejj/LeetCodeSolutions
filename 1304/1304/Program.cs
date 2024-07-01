class Program
{
    /*
     Given an integer n, return any array containing n unique integers such that they add up to 0.
     */

    static void Main(string[] args)
    {

    }
    public int[] SumZero(int n)
    {
        //-2,-1,0,1,2
        //n=6
        // -3,-2,-1,1,2,3
        int[] result = new int[n];
        if(n % 2 ==0)
        {
            for(int i = 0; i<n/2; i++)
            {
                result[i]=i-n/2;
            }
            for(int j=0;j<n/2; j++)
            {
                result[j+n/2]=j+1;
            }
        }
        else
        {
            result[n/2]=0;
            for(int i = 0; i<n/2; i++)
            {
                result[i]=i-n/2;
            }
            for(int j=0;j<n/2; j++)
            {
                result[j+n/2+1]=j+1;
            }
        }
        return result;
    }
}