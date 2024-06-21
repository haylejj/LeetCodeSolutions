class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(NumberOfPairs(new int[] {1,2,4,12},new int[] {2,4},3));
    }
    public static int NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        int n=nums1.Length;
        int m=nums2.Length;
        int count=0;
        for(int i = 0; i<n; i++)
        {
            for(int j = 0; j<m; j++)
            {
                  if (nums1[i] % (nums2[j]*k)==0) count++;
            }
        }
        return count;  
    }
}

