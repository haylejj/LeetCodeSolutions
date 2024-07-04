class Program
{
    /*
     Given two integer arrays nums1 and nums2, return an array of their intersection. 
    Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
     */
    static void Main(string[] args)
    {

    }
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        for(int i = 0; i<nums1.Length; i++)
        {
            for(int j=0; j<nums2.Length; j++)
            {
                if (nums1[i]==nums2[j])
                {
                    result.Add(nums1[i]);
                    nums2[j] = -1;
                    break;
                }
            }
        }
        return result.ToArray();
    }
}