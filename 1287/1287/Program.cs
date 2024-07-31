class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindSpecialInteger(new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 }));
    }
    public static int FindSpecialInteger(int[] arr)
    {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int i in arr)
        {
            if (map.ContainsKey(i)) map[i]++;
            else map[i] = 1;
        }
        int max=int.MinValue;
        int key = 0;
        foreach(int i in map.Keys)
        {
            if (max < map[i])
            {
                max=map[i];
                key=i;
            }
        }
        return key;
    }
}