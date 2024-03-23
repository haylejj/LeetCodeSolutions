using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MaximizeSum(new int[] {1,2,3,4,5},3));
    }

    /*
     You are given a 0-indexed integer array nums and an integer k. Your task is to perform the following operation exactly k times in order to maximize your score:

    Select an element m from nums.
    Remove the selected element m from the array.
    Add a new element with a value of m + 1 to the array.
    Increase your score by m.
    Return the maximum score you can achieve after performing the operation exactly k times.
     */
    public static int MaximizeSum(int[] nums, int k)
    {
        int point = 0;
        Array.Sort(nums);

        for(int i = 1;i<=k;i++)
        {
            int selected = nums[nums.Length-1] + 1;
            nums[nums.Length-1] = selected;
            point+=selected-1;
        }
        return point;
    }

}
