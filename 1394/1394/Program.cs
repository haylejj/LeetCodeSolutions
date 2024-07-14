class Program
{
    static void Main(string[] args)
    {

    }
    public int FindLucky(int[] arr)
    {
        Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
        foreach(var item in arr)
        {
            if(keyValuePairs.ContainsKey(item)) keyValuePairs[item]++;
            else keyValuePairs[item] = 1;
        }
        return keyValuePairs.Where(x => x.Key==x.Value).Count() >0  ? keyValuePairs.Where(x => x.Key==x.Value).Max(x => x.Key) : -1;
    }
}