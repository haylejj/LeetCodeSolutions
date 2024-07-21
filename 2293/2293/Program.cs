class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MinMaxGame(new int[] { 1, 3, 5, 2, 4, 8, 2, 2 }));
    }
    public static int MinMaxGame(int[] nums)
    {
        int n = nums.Length;
        if (n == 0) return 0;
        if(n == 1) return nums[0];
        while (nums.Length>1)
        {
            int[] newNums = new int[nums.Length/2];
            for (int i = 0; i<nums.Length/2; i++)
            {
                if (i%2 != 0)
                {
                    newNums[i]=Math.Max(nums[2*i], nums[2*i+1]);
                }
                else
                {
                    newNums[i]=Math.Min(nums[2*i], nums[2*i+1]);
                }
            }
            nums=newNums;
        }
        return nums[0];
        
    }
}