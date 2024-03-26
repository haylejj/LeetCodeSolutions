using System.Collections.Generic;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(MinimumRightShifts(new List<int> { 3, 4, 5, 1, 2 }));
    }
    /*
     You are given a 0-indexed array nums of length n containing distinct positive integers. 
    Return the minimum number of right shifts required to sort nums and -1 if this is not possible.
    A right shift is defined as shifting the element at index i to index (i + 1) % n, for all indices.
     */
    public static int MinimumRightShifts(IList<int> nums)
    {
        int pivots = 0;
        int n = nums.Count;
        int ans = 0;
        for (int i = 0; i != n; ++i)
        {
            if (nums[i] >= nums[(i - 1 + n) % n]) continue;
            ++pivots;
            ans = (n - i) % n; // the number of values after the pivot
        }
        if (pivots > 1) return -1; // too many pivots
        return ans;





        //int count = 0;

        //for(int j=0; j<nums.Count; j++)
        //{
        //    int temp = nums[nums.Count - 1];
        //    for (int i = nums.Count - 1; i > 0; i--)
        //    {
        //        nums[i] = nums[i - 1];
        //    }
        //    nums[0] = temp;
        //    count++;
        //}
        //return count;
    }
    //public static bool isSort(IList<int> nums)
    //{
    //    var sortedList = nums.OrderBy(x => x).ToList();
    //    return nums.SequenceEqual(sortedList);
    //}
}
