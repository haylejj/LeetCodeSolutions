class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindMiddleIndex(new int[] { 4, 2, 1, -3 }));
    }
    public static int FindMiddleIndex(int[] nums)
    {
        List<int> list = new List<int>();
        for (int i = 0; i<nums.Length; i++)
        {
            var tempSum =FindTempSum(nums, i+1);
            if (list.Sum()==tempSum) return i;
            list.Add(nums[i]);
        }
        return -1;
    }
    private static int FindTempSum(int[] nums,int i)
    {
        int sum = 0;
        for (int j = i; j<nums.Length; j++) sum+=nums[j];
        return sum;
    }
}