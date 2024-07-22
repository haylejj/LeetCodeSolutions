class Program
{
    static void Main(string[] args)
    {
        MoveZeroes(new int[] { 0, 0, 1 });
    }
    public static void MoveZeroes(int[] nums)
    {
        for(int i=0;i<nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                var tempIndex = i;
                for (int j = i+1; j<nums.Length; j++)
                {
                    if (nums[j]==0) continue;
                    else
                    {
                        var temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        i=j;
                    }
                    
                }
                i=tempIndex;
            }       
        }
    }
}