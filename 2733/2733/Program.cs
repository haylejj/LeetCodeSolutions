class Program
{
    /*
     Given an integer array nums containing distinct positive integers, 
     find and return any number from the array that is neither the minimum nor the maximum value in the array, or -1 if there is no such number.
     Return the selected integer.
     */
    static void Main(string[] args)
    {

    }
    public int FindNonMinOrMax(int[] nums)
    {
        if (nums.Length<=2)
        {
            return -1;
        }
        Array.Sort(nums);
        return nums[1];

    }
}