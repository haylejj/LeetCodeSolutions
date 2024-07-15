class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SpecialArray(new int[] { 0, 4, 3, 0, 4 }));
    }
    public static int SpecialArray(int[] nums)
    {
        int count = 0;
        foreach(var item in Enumerable.Range(1, nums.Length))
        {
            foreach(var num in nums)
            {
                if(item<=num) count++;
            }
            if (item==count) return item;
            count=0;
        }
        return -1;
    }
}