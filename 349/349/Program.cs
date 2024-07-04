class Program
{
    /*
     Given two integer arrays nums1 and nums2, return an array of their 
    intersection
.   Each element in the result must be unique and you may return the result in any order.
     */
    static void Main(string[] args)
    {

    }
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        set1.IntersectWith(set2);
        return set1.ToArray();
    }
}