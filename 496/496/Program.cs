class Program
{
    /*
     The next greater element of some element x in an array is the first greater element that is to the right of x in the same array.

    You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.

    For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element of nums2[j] in nums2. 
    If there is no next greater element, then the answer for this query is -1.

    Return an array ans of length nums1.length such that ans[i] is the next greater element as described above.
     */
    static void Main()
    {
        Console.WriteLine(NextGreaterElement(new int[] { 1, 3, 5, 2, 4 },new int[] { 6, 5, 4, 3, 2, 1, 7 }));
    }
    public static int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        List<int> list = new List<int>();
        List<int> nums2List= nums2.ToList();
        for (int i = 0; i < nums1.Length; i++)
        {
            int index=nums2List.IndexOf(nums1[i]);
            if (index==nums2.Length-1)
            {
                list.Add(-1);
                continue;
            }
            var count = 0;
            for(int j=index+1;j<nums2.Length;j++)
            {
                if (nums2[j]>nums1[i])
                {
                    list.Add(nums2[j]);
                    count++;
                    break;
                }
            }
            if(count==0) list.Add(-1);
        }
        return list.ToArray();
    }
}