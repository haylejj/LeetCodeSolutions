class Program
{
    /*
     Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

    Return any array that satisfies this condition.
     */

    static void Main(string[] args)
    {

    }
    public int[] SortArrayByParity(int[] nums)
    {
        int k= 0;
        for(int i = 0; i<nums.Length; i++)
        {
            if (nums[i]%2==0)
            {
                int temp=nums[i];
                nums[i]=nums[k];
                nums[k]=temp;
                k++;
            }
        }
        return nums;
    }
}