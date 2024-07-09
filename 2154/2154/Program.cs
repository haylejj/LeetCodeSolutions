class Program
{
    static void Main()
    {
        Console.WriteLine(FindFinalValue(new int[] { 8, 19, 4, 2, 15, 3 },2));
    }
    public static int FindFinalValue(int[] nums, int original)
    {
        for(int i = 0; i<nums.Length; i++)
        {
            if (nums[i]==original)
            {
                original*=2;
                i=-1;
            }
        }
        return original;
    }
}