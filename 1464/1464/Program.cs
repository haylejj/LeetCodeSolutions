class Program
{
    /*
     *  Given the array of integers nums, you will choose two different indices i and j of that array. Return the maximum value of (nums[i]-1)*(nums[j]-1).
 
     */
    static void Main(string[] args)
    {
    }
    public int MaxProduct(int[] nums)
    {
        //int sum = 0;
        //for(int i=0;i<nums.Length;i++)
        //{
        //    for(int j=i+1;j<nums.Length;j++)
        //    {
        //        sum = Math.Max(sum, (nums[i]-1)*(nums[j]-1));
        //    }
        //}
        //return sum;
        Array.Sort(nums);
        return (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);
    }
}