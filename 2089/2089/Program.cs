class Program
{
    /*
     You are given a 0-indexed integer array nums and a target element target.

    A target index is an index i such that nums[i] == target.

    Return a list of the target indices of nums after sorting nums in non-decreasing order. 
    If there are no target indices, return an empty list. The returned list must be sorted in increasing order.
     */

    static void Main(string[] args)
    {
        
    }
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Array.Sort(nums);
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                result.Add(i);
            }
            if(nums[i] > target)
            {
                break;
            }
        }
        return result;
    }
}
