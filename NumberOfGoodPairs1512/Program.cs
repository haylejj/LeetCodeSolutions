class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 }));
        Console.WriteLine(NumIdenticalPairs(new int[] { 1,1,1,1 }));
        Console.WriteLine(NumIdenticalPairs(new int[] { 1, 2, 3 }));
    }
    public static int NumIdenticalPairs(int[] nums)
    {
        int numberOfGoodPairs = 0;
        for (int i=0;i <nums.Length; i++)
        {
            for(int j=i+1;j <nums.Length;j++)
            {
                if (nums[i] == nums[j] && i < j)
                {
                    numberOfGoodPairs++;
                }   
            }
        }
        return numberOfGoodPairs;
    }
}
