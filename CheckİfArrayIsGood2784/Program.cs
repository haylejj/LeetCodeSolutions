using System.Collections.Specialized;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsGood(new int[] { 5, 1, 2, 2, 5, 1 }));
    }

    /*
     You are given an integer array nums. We consider an array good if it is a permutation of an array base[n].

    base[n] = [1, 2, ..., n - 1, n, n] (in other words, it is an array of length n + 1 which contains 1 to n - 1 exactly once, plus two occurrences of n). For example, base[1] = [1, 1] and base[3] = [1, 2, 3, 3].

    Return true if the given array is good, otherwise return false.

    Note: A permutation of integers represents an arrangement of these numbers.
     */
    
    public static bool IsGood(int[] nums)
    {
        Array.Sort(nums);
        var n = nums.Length - 1;
        for (int i = 0; i<n; i++)
        {
            if (nums[i] != i+1)
                return false;
        }
        return nums[n]==n ? true : false;

    }
}
