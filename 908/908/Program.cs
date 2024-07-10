class Program
{
    static void Main(string[] args)
    {

    }
    public int SmallestRangeI(int[] nums, int k)
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        for(int i = 0; i<nums.Length; i++)
        {
            max=Math.Max(max,nums[i]);
            min=Math.Min(min,nums[i]);
        }
        return max-min<=2*k ? 0 : max-min-2*k;
    }
}