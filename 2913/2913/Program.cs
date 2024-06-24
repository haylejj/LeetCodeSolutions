class Program
{
    /*
     *  You are given a 0-indexed integer array nums.

    The distinct count of a subarray of nums is defined as:

    Let nums[i..j] be a subarray of nums consisting of all the indices from i to j such that 0 <= i <= j < nums.length. Then the number of distinct values in nums[i..j] is called the distinct count of nums[i..j].
    Return the sum of the squares of distinct counts of all subarrays of nums.

    A subarray is a contiguous non-empty sequence of elements within an array.
 
     */
    static void Main(string[] args)
    {
        Console.WriteLine(SumCounts(new List<int> { 1, 2, 1 }));
    }
    public static int SumCounts(IList<int> nums)
    {
        // 1, 12 , 121 1+2+2
        // 2, 21  2+1
        // 1  1 
        //int sum = 0;
        //for(int i = 0; i<nums.Count; i++)
        //{
        //    for(int j = i; j<nums.Count; j++)
        //    {
        //        sum+=(int)Math.Pow(nums.Skip(i).Take(j-i+1).Distinct().Count(),2);
        //    }
        //}
        //return sum;
        int sum = 0;
        for(int i = 0; i<nums.Count; i++)
        {
            HashSet<int> distinctSet = new HashSet<int>();
            for(int j = i; j<nums.Count; j++)
            {
                distinctSet.Add(nums[j]);
                sum+=(int)Math.Pow(distinctSet.Count,2);
            }
        }
        return sum;
    }
}