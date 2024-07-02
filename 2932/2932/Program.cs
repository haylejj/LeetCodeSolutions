class Program
{
    /*
     You are given a 0-indexed integer array nums. A pair of integers x and y is called a strong pair if it satisfies the condition:

    |x - y| <= min(x, y)
    You need to select two integers from nums such that they form a strong pair and their bitwise XOR is the maximum among all strong pairs in the array.

    Return the maximum XOR value out of all possible strong pairs in the array nums.

    Note that you can pick the same integer twice to form a pair.
     */
    static void Main(string[] args)
    {

    }
    public int MaximumStrongPairXor(int[] nums)
    {
        int maxXor = 0;
        for(int i = 0; i<nums.Length-1; i++)
        {
            for(int j=0; j<nums.Length; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) <= Math.Min(nums[i], nums[j]))
                {
                    var temp= nums[i] ^ nums[j];
                    maxXor = Math.Max(maxXor, temp);
                }
            }
        }
        return maxXor;
    }
}