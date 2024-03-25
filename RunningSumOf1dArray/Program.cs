using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        foreach (var arg in RunningSum(new int[] { 3, 1, 2, 10, 1 }))
        {
            Console.Write(arg+" ");
        }
    }
    /*
     Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
     Return the running sum of nums.
     */
    public static int[] RunningSum(int[] nums)
    {
        int sum = 0;
        int[] result=nums.Select(x => sum += x).ToArray();
        return result;
    }

}
