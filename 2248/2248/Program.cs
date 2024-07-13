class Program
{
    static void Main(string[] args)
    {

    }
    public IList<int> Intersection(int[][] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i<nums.Length; i++)
        {
           for(int j=0; j<nums[i].Length; j++)
           {
                if (dict.ContainsKey(nums[i][j]))
                    dict[nums[i][j]]++;
                else
                    dict[nums[i][j]]=1;
           }
        }
        List<int> result = new List<int>();
        foreach(var item in dict)
        {
            if(item.Value==nums.Length)
                result.Add(item.Key);
        }
        result.Sort();
        return result;
    }
}