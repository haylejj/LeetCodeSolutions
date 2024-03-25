
class Program
{
    static void Main(string[] args)
    {
        foreach (var item in SmallerNumbersThanCurrent(new int[]{ 6,5,4,8}))
        {
            Console.Write(item+ " ");
        }
    }
    /*
     Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it.
     That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
     Return the answer in an array.
     */
    public static  int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int count = 0;
        int [] result=new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j<nums.Length; j++)
            {
                if (nums[i]>nums[j]) count++;
            }
            result[i] = count;
            count=0;
        }
        return result;
    }

}
