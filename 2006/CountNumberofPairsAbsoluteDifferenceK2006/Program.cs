class Program
{
    /*
    Given an integer array nums and an integer k, return the number of pairs (i, j) where i < j such that |nums[i] - nums[j]| == k.

    The value of |x| is defined as:

    x if x >= 0.
    -x if x < 0.
 
     */
    static void Main(string[] args)
    {
        Console.WriteLine(CountKDifference(new int[] { 3, 2, 1, 5, 4 },2));
    }
    public static int CountKDifference(int[] nums, int k)
    {
        int count = 0;
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=i+1; j<nums.Length; j++)
            {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        count++;
                    }
            }
        }
        return count;
    }
}
