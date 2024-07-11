class Program
{
    static void Main(string[] args)
    {

    }
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(arr);
        var minAbsDiff = int.MaxValue;
        for (int i = 0; i<arr.Length-1; i++)
        {
            minAbsDiff=Math.Min(minAbsDiff, Math.Abs(arr[i] - arr[i+1]));
        }
        for (int i = 0; i<arr.Length-1; i++)
        {
            if (Math.Abs(arr[i] - arr[i+1])==minAbsDiff)
            {
                result.Add(new List<int>() { arr[i], arr[i+1] });
            }
        }
        return result.ToArray();
    }
}