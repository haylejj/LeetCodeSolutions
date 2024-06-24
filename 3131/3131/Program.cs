class Program
{
    /*
     You are given two arrays of equal length, nums1 and nums2.

    Each element in nums1 has been increased (or decreased in the case of negative) by an integer, represented by the variable x.

    As a result, nums1 becomes equal to nums2. Two arrays are considered equal when they contain the same integers with the same frequencies.

    Return the integer x.

 
     */
    static void Main(string[] args)
    {

    }
    public int AddedInteger(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        return nums2[0]- nums1[0];
    }
}