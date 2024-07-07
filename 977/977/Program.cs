class Program
{
    /*
     Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(SortedSquares(new int[] { -4, -1, 0, 9, 10 }));
    }
    public static int[] SortedSquares(int[] nums)
    {
        //for (int i = 0; i<nums.Length; i++)
        //{
        //    nums[i]=nums[i]*nums[i];
        //}
        ////insertion sort
        //int j,selected;
        //for(int i = 1; i<nums.Length; i++)
        //{
        //    selected=nums[i];
        //    for(j=i-1;j>=0 && nums[j]>selected; j--)
        //        nums[j+1]=nums[j];          
        //    nums[j+1]=selected;
        //}
        //return nums;

        // we need to sort O(n) time complexity
        //-4,-1,0,3,10
        int leftptr = 0;
        int rightptr = nums.Length - 1;
        int[] result = new int[nums.Length];
        for(int i = nums.Length-1; i>=0; i--)
        {

           if (Math.Abs(nums[leftptr]) > Math.Abs(nums[rightptr]))
            {
                result[i] = nums[leftptr] * nums[leftptr];
                leftptr++;
            }
            else
            {
                result[i] = nums[rightptr] * nums[rightptr];
                rightptr--;
            }
        }
        return result;
    }
}