class Program
{
    static void Main(string[] args)
    {

    }
    public int MinimumOperations(int[] nums)
    {
        //int j,selected;
        //for(int i = 1; i<nums.Length; i++)
        //{
        //    selected= nums[i];
        //    for (j=i-1; j>=0 && nums[j]>selected; j--)
        //    {
        //        nums[j+1]=nums[j];
        //    }
        //    nums[j+1]=selected;
        //}
        var result = nums.Distinct().Count();
        if (nums.Contains(0)) return result-1;
        else return result;
    }
}