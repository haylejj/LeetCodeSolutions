class Program
{
    /*
     You are given an integer array nums (0-indexed). In one operation, you can choose an element of the array and increment it by 1.

    For example, if nums = [1,2,3], you can choose to increment nums[1] to make nums = [1,3,3].
    Return the minimum number of operations needed to make nums strictly increasing.

    An array nums is strictly increasing if nums[i] < nums[i+1] for all 0 <= i < nums.length - 1. An array of length 1 is trivially strictly increasing.

 
     */
    static void Main(string[] args)
    {
        Console.WriteLine(MinOperations(new int[] {1,5,2,4,1}));
    }
    public static int MinOperations(int[] nums)
    {
        //1,5,2,4,1
        //1,1,2,4,5
        int count = 0;
        for (int i = 0;  i< nums.Length-1; i++)
        {
            if (nums[i] >= nums[i+1])
            {
                count+=nums[i]-nums[i+1]+1;
                nums[i+1]=nums[i]+1;
            }
        }
        return count;
    }
}