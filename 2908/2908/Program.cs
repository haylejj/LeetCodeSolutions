class Program
{
    static void Main(string[] args)
    {

    }
    public int MinimumSum(int[] nums)
    {
        int minSum = int.MaxValue;
        for(int i=0;i<nums.Length; i++)
        {
            for(int j = i+1; j<nums.Length; j++)
            {
                for(int k=j+1; k<nums.Length; k++)
                {
                    var temp = nums[i]+nums[j]+nums[k];
                    if (nums[i]<nums[j] && nums[k]<nums[j]) minSum=Math.Min(minSum, temp);
                }
            }
        }
        return minSum ==int.MaxValue ? -1 : minSum;
    }
}