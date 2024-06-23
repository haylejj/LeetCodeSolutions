class Program
{
    /*
     You are given two integer arrays nums1 and nums2 of sizes n and m, respectively. Calculate the following values:

    answer1 : the number of indices i such that nums1[i] exists in nums2.
    answer2 : the number of indices i such that nums2[i] exists in nums1.
    Return [answer1,answer2].
     */
    static void Main(string[] args)
    {
        foreach (var item in FindIntersectionValues(new int[] { 2, 3, 2 },new int[] {1,2}))
        {
            Console.Write(item);
        }
    }
    public static int[] FindIntersectionValues(int[] nums1, int[] nums2)
    {
        int[] result=new int[2];
        int count1 = 0;
        int count2 = 0;
        result[0] = nums1.Count(x => nums2.Contains(x));
        result[1] = nums2.Count(x => nums1.Contains(x));

        return result;
    }
}