class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FrequencySort(new int[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 }));
    }
    public static int[] FrequencySort(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(var item in nums)
        {
            if (dict.ContainsKey(item)) dict[item]++;
            else dict[item] = 1;
        }
        return dict.OrderBy(x=>x.Value).ThenByDescending(x=>x.Key).SelectMany(x=>Enumerable.Repeat(x.Key, x.Value)).ToArray();
       
    }
}