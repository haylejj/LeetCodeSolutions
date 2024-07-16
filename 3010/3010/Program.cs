class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MinimumCost(new int[] { 12, 33, 12, 6, 8, 46, 27, 10, 27, 23 }));
    }
    public static int MinimumCost(int[] nums)
    {
        int j, selected;
        for(int i = 2; i<nums.Length; i++)
        {
            selected = nums[i];
            for(j=i-1;j>=1 && nums[j]>selected; j--)
                nums[j+1]=nums[j];
            nums[j+1] = selected;
        }
        int count = 0;
        for(int i=0; i<3; i++)
        {
            count+=nums[i];
        }
        return count;
    }
}