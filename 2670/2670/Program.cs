class Program
{
    /*
     You are given a 0-indexed array nums of length n.

    The distinct difference array of nums is an array diff of length n such that diff[i] is equal to the number of distinct elements in the suffix nums[i + 1, ..., n - 1] subtracted from the number of distinct elements in the prefix nums[0, ..., i].

    Return the distinct difference array of nums.

    Note that nums[i, ..., j] denotes the subarray of nums starting at index i and ending at index j inclusive. Particularly, if i > j then nums[i, ..., j] denotes an empty subarray.
     */
    static void Main(string[] args)
    {

    }
    public int[] DistinctDifferenceArray(int[] nums)
    {
        int suffix= 0;
        int prefix = 0;
        int[] diff = new int[nums.Length];
        HashSet<int> set = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            set.Add(nums[i]);
            prefix = set.Count;
            for(int j = i+1; j<nums.Length; j++)
            {
                set2.Add(nums[j]);
            }
            suffix = set2.Count;
            diff[i] = prefix - suffix;
            set2.Clear();
        }
        return diff;
    }
}