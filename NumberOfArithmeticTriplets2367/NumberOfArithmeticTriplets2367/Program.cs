class Program
{
    /*
    You are given a 0-indexed, strictly increasing integer array nums and a positive integer diff. A triplet (i, j, k) is an arithmetic triplet if the following conditions are met:

    i < j < k,
    nums[j] - nums[i] == diff, and
    nums[k] - nums[j] == diff.
    Return the number of unique arithmetic triplets.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(ArithmeticTriplets(new int[] { 0, 1, 4, 6, 7, 10 },3));
    }
    public static int ArithmeticTriplets(int[] nums, int diff)
    {
        int count=0;
        for(int i = 0; i<nums.Length-2; i++)
        {
            for(int j = i+1; j<nums.Length-1; j++)
            {
                if (nums[j]-nums[i]==diff)
                {
                    for(int k = j+1; k<nums.Length; k++)
                    {
                        if (nums[k]-nums[j]==diff) count++;
                    }
                }
            }
        }
        return count;
    }
}
