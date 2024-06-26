class Program
{
    /*
     Given an integer array nums of 2n integers, 
    group these integers into n pairs (a1, b1), (a2, b2), ..., (an, bn) such that the sum of min(ai, bi) for all i is maximized. 
    Return the maximized sum.
     */
    static void Main(string[] args)
    {

    }
    public int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);
        int sum = 0;
        sum=Math.Min(nums[nums.Length - 1], nums[nums.Length - 2]);
        for (int i = 0; i < nums.Length - 2; i += 2)
        {
            sum += Math.Min(nums[i], nums[i + 1]);
        }
        return sum;
    }
}