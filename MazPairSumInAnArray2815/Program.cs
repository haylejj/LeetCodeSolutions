using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MaxSum(new int[] { 31, 25, 72, 79, 74 }));
    }
    /*
     You are given a 0-indexed integer array nums. 
    You have to find the maximum sum of a pair of numbers from nums such that the maximum digit in both numbers are equal.
    Return the maximum sum or -1 if no such pair exists.
     */
    // bizim burada sayının en büyük rakamnı da bulmamız lazım.
    public static int MaxSum(int[] nums)
    {
        int max = -1;
        int maxDigit = 0;
        for (int i = 0; i<nums.Length-1; i++)
        {
            maxDigit=MaxDigit(nums[i]);
            int maxT = 0;
            for (int j = i+1; j<nums.Length; j++)
            {
                maxT=MaxDigit(nums[j]);
                if (maxT==maxDigit)
                    max=Math.Max(max, nums[i]+nums[j]);
            }
        }
        return max;
    }
    public static int MaxDigit(int num)
    {
        int max = 0;
        while (num !=0)
        {
            int n = num % 10;
            max=Math.Max(n, max);
            num=num/10;
        }
        return max;
    }
}
