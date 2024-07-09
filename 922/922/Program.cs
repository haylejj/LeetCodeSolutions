class Program
{
    static void Main(string[] args)
    {

    }
    public int[] SortArrayByParityII(int[] nums)
    {
        //4,2,5,7
        for (int i = 0; i<nums.Length; i++)
        {
            if(i%2==0 && nums[i] % 2 ==0) continue;
            if(i%2==1 && nums[i] % 2 ==1) continue;
            for(int j = i+1; j<nums.Length; j++)
            {
                if(i%2==0 && nums[j] % 2 ==0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    break;
                }
                if(i%2==1 && nums[j] % 2 ==1)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    break;
                }
            }
        }
        return nums;
    }
}