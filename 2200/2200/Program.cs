class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindKDistantIndices(new int[] { 3, 4, 9, 1, 3, 9, 5 },9,1));
    }
    public static IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        List<int> result = new List<int>();
        List<int> dist = new List<int>();
        for(int i= 0; i < nums.Length; i++)
        {
            if (nums[i]==key) result.Add(i);
        }
        for (int i = 0; i<nums.Length; i++)
        {
            for(int j = 0; j<result.Count; j++)
            {
                if (Math.Abs(i-result[j])<=k)
                {
                    dist.Add(i);
                    break;
                }
            }
        }
        return dist;
    }
}