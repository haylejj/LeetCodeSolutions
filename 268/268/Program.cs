class Program
{
    static void Main(string[] args)
    {

    }
    public int MissingNumber(int[] nums)
    {
        //int length = nums.Length+1;
        //int j, selected;
        //for(int i = 1; i<nums.Length; i++)
        //{
        //    selected = nums[i];
        //    for(j=i-1;j>=0 && nums[j]>selected; j--)
        //        nums[j+1]= nums[j];
        //    nums[j+1] = selected;
        //}
        //if(nums.Length!= nums.Max()) return nums.Length;
        //for(int i = 1; i<nums.Length; i++)
        //{
        //    if (nums[i]-nums[i-1]!=1) return nums[i-1]+1;
        //}
        //return 0;
        int n= nums.Length;
        int reelSum = (n*(n+1))/2;//sum of consecutive numbers
        int mockSum = 0;
        foreach(int i in nums)
            mockSum += i;
        return reelSum-mockSum;
    }
}