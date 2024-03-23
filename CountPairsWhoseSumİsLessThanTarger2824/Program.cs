using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CountPairs(new int[] {-1,1,2,3,1},2));
    }

    /*
     Given a 0-indexed integer array nums of length n and an integer target,
     return the number of pairs (i, j) where 0 <= i < j < n and nums[i] + nums[j] < target.
     */
    public static int CountPairs(IList<int> nums, int target)
    {
        
        int count = 0;
        //1,2,3,4,5,6,7,8
        for (int i = 0; i<nums.Count; i++)
        {
            for(int j = i+1; j<nums.Count; j++)
            {
                if (nums[i] + nums[j] < target)
                    count++;
            }
        }

        return count;
    }

}
