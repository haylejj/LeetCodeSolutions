class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CountQuadruplets(new int[] { 1, 1, 1, 3, 5 }));
    }
    public static int CountQuadruplets(int[] nums)
    {
        //a+ a+1 = a+3 - a+2
        //a+b=d-c
        //int count= 0;
        //for(int i = 0; i<nums.Length-1; i++)
        //{
        //    for(int j = i+2; j<nums.Length-1; j++)
        //    {
        //        if (nums[i]+nums[i+1]==nums[j+1]-nums[j]) count++;
        //    }
        //}
        //return count;
        int count = 0;
        for (int i = 0; i<nums.Length-3; i++)
        {
            for (int j = i+1; j<nums.Length-2; j++)
            {
                for (int m = j+1; m < nums.Length-1; m++)
                {
                    for (int k = m+1; k < nums.Length; k++)
                    {
                        if (nums[i]+nums[j]+nums[m]==nums[k]) count++;
                    }
                }
            }
        }
        return count;
    }
}