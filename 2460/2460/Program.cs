class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ApplyOperations(new int[] { 1, 2, 2, 1, 1, 0 }));
    }
    public static int[] ApplyOperations(int[] nums)
    {
        int[] result = new int[nums.Length];
        int count = 0;
        for(int i = 0; i<nums.Length-1; i++)
        {
            if (nums[i]==nums[i+1])
            {
                nums[i]=nums[i]*2;
                nums[i+1]=0;
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
                result[count++] = nums[i];
        }
        return result;
        //for(int i = 0; i<nums.Length-1; i++)
        //{
        //    for (int j = i+1; j<nums.Length; j++)
        //    {
        //        if (nums[i]==0)
        //        {
        //            var temp= nums[j];
        //            nums[j]=nums[i];
        //            nums[i]=temp;
        //        }
        //    } 
        //}

    }
}