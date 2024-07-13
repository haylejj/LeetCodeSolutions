class Program
{
    static void Main(string[] args)
    {

    }
    public int DistributeCandies(int[] candyType)
    {
        int n=candyType.Length/2;
        HashSet<int> set = new HashSet<int>();
        foreach(var item in candyType)
        {
            set.Add(item);
        }
        return Math.Min(n, set.Count);
    }
}