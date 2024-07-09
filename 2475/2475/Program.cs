class Program
{
    static void Main(string[] args)
    {

    }
    public int UnequalTriplets(int[] nums)
    {
        int count = 0;
        for(int i = 0; i<nums.Length; i++)
        {
            for(int j=i+1; j<nums.Length; j++)
            {
                for(int k = j+1; k<nums.Length; k++)
                {
                    if (nums[i] != nums[j] && nums[j] != nums[k] && nums[i] != nums[k])
                        count++;
                }
            }
        }
        return count;
    }
}