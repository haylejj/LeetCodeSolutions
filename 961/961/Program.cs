class Program
{
    /*
     You are given an integer array nums with the following properties:

    nums.length == 2 * n.
    nums contains n + 1 unique elements.
    Exactly one element of nums is repeated n times.
    Return the element that is repeated n times.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(RepeatedNTimes(new int[] {1,2,3,3}));
    }
    public static int RepeatedNTimes(int[] nums)
    {
        int n= nums.Length / 2;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (dict.ContainsKey(item)) dict[item]++;
            else dict.Add(item, 1);
        }
        int key = 0;
        foreach (var item in dict)
        {
            if (item.Value == n)
            {
                key = item.Key;
                break;
            }
        }
        return key;
    }
}