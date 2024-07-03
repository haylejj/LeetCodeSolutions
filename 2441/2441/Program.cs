class Program
{
    /*
     Given an integer array nums that does not contain any zeros, find the largest positive integer k such that -k also exists in the array.

    Return the positive integer k. If there is no such integer, return -1.

 
     */
    static void Main(string[] args)
    {

    }
    public int FindMaxK(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int max = -1;
        for(int i = 0; i < nums.Length; i++)
        {
            if(set.Contains(-nums[i]))
            {
                max= Math.Max(max, nums[i]);
            }
        }
        return max;
    }
}