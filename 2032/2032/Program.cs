class Program
{
    /*
     Given three integer arrays nums1, nums2, and nums3, 
     return a distinct array containing all the values that are present in at least two out of the three arrays. You may return the values in any order.
     */
    static void Main(string[] args)
    {

    }
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        HashSet<int> dict = new HashSet<int>();
        foreach (var item in nums1)
        {
            dict.Add(item);
        }
        foreach (var item in nums2)
        {
            dict.Add(item);
        }
        foreach (var item in nums3)
        {
            dict.Add(item);
        }
        List<int> result = new List<int>();
        foreach (var item in dict)
        {
            int count = 0;
            if (nums1.Contains(item))
            {
                count++;
            }
            if (nums2.Contains(item))
            {
                count++;
            }
            if (nums3.Contains(item))
            {
                count++;
            }
            if (count >= 2)
            {
                result.Add(item);
            }
        }
        return result;
    }
}