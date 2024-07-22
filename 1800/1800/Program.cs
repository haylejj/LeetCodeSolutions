class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MaxAscendingSum(new int[] { 12, 17, 15, 13, 10, 11, 12 })); 
    }
    public static int MaxAscendingSum(int[] nums)
    {
        int maxSum = 0;
        for (int i = 0; i<nums.Length; i++)
        {
            var tempSum = nums[i];
            for (int j = i+1; j<nums.Length; j++)
            {
                if (nums[i]<nums[j])
                {
                    tempSum+=nums[j];
                    i++;
                }
                else break;
            }
            maxSum=Math.Max(maxSum, tempSum);
        }
        return maxSum;
    }
}