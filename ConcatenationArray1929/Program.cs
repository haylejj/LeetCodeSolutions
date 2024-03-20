class Program
{
    static void Main(string[] args)
    {
        foreach(var item in GetConcatentation(new int[] { 1, 4, 5, 2, 3, 7, 0 }))
        {
            Console.Write(item+" ");
        }
    }
    public static int[] GetConcatentation(int[] nums)
    {
        int n=nums.Length;
        int[] result = new int[2*n];

        for(int i=0; i<n; i++)
        {
            result[i] = nums[i];
            result[i+n]=nums[i];
        }
        return result;
    }
}