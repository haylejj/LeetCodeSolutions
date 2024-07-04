class Program
{
    /*
     You are given an integer array nums.

     In one move, you can choose one element of nums and change it to any value.

     Return the minimum difference between the largest and smallest value of nums after performing at most three moves.
     */
    static void Main(string[] args)
    {

    }
    public int MinDifference(int[] nums)
    {
        if(nums.Length<=4)
        {
            return 0;
        }
        Array.Sort(nums);
        int diff = int.MaxValue;
        for(int i = 0; i<4; i++)
        {
            diff=Math.Min(diff, nums[nums.Length-4+i]-nums[i]);
        }
        return diff;
    }
}