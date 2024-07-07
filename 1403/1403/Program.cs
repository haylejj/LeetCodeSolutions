class Program
{
    /*
     Given the array nums, obtain a subsequence of the array whose sum of elements is strictly greater than the sum of the non included elements in such subsequence. 
     If there are multiple solutions, return the subsequence with minimum size and if there still exist multiple solutions, 
    return the subsequence with the maximum total sum of all its elements. 
    A subsequence of an array can be obtained by erasing some (possibly zero) elements from the array. 
    Note that the solution with the given constraints is guaranteed to be unique. Also return the answer sorted in non-increasing order.
     */
    static void Main(string[] args)
    {

    }
    public IList<int> MinSubsequence(int[] nums)
    {
        List<int> list = new List<int>();
        int j = 0;
        for (int i = 1; i<nums.Length; i++)
        {
            int selected = nums[i];
            for (j=i-1; j>=0 && selected<nums[j]; j--)
            {
                nums[j+1]=nums[j];
            }
            nums[j+1]=selected;
        }
        int sum = 0;
        for (int i = nums.Length-1; i>=0; i--)
        {
            sum+=nums[i];
            list.Add(nums[i]);
            if (sum>nums.Sum()-sum)
            {
                break;
            }
        }
        return list;
    }
}