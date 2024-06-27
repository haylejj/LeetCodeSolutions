class Program
{
    /*
     Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:

    answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
    answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
    Note that the integers in the lists may be returned in any order.
     */
    static void Main(string[] args)
    {

    }
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        List<int> result1 = new List<int>();
        List<int> result2 = new List<int>();
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                result1.Add(num);
            }
        }

        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                result2.Add(num);
            }
        }
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(result1);
        result.Add(result2);
        return result;
    }
}