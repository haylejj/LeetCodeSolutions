class Program
{
    static void Main(string[] args)
    {
        foreach (var arg in BuildArray(new int[] {0,2,1,5,3,4}) )
        {
            Console.Write(arg+" ");
        }
    }
    public static int[] BuildArray(int[] nums)
    {
        int[] result= new int[nums.Length];

        for(int i=0; i<nums.Length; i++)
        {
            result[i]=nums[nums[i]];
        }
        return result;
    }
}
