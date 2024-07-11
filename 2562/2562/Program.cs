class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindTheArrayConcVal(new int[] { 1, 78, 27, 48, 14, 86, 79, 68, 77, 20, 57, 21, 18, 67, 5, 51, 70, 85, 47, 56, 22, 79, 41, 8, 39, 81, 59, 74, 14, 45, 49, 15, 10, 28 }));
    }
    public static long FindTheArrayConcVal(int[] nums)
    {
        long sum = 0;
        int n = nums.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int first = nums[i];
            int last = nums[n - i - 1];
            sum += long.Parse(first.ToString() + last.ToString());
        }
        if (n % 2 != 0)
        {
            sum += nums[n / 2];
        }
        return sum;
    }
}