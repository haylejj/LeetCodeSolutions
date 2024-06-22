class Program
{
    /*
     You are given an array nums, where each number in the array appears either once or twice.

    Return the bitwise XOR of all the numbers that appear twice in the array, or 0 if no number appears twice.
     */
    static void Main(string[] args)
    {

    }
    public int DuplicateNumbersXOR(int[] nums)
    {
        List<int> twices = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] )
                {
                    twices.Add(nums[i]);
                }
            }
        }
        int result = 0;
        foreach (var item in twices)
        {
            result ^= item;
        }
        return result;
    }
}
