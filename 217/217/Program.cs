class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 4 }));
    }
    public static bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach (int num in nums)
        {
            if(map.ContainsKey(num)) map[num]++;
            else map[num] = 1;
        }
        foreach (int num in map.Values)
        {
            if(num !=1) return true;
        }
        return false;
    }
}