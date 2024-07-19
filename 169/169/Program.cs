class Program
{
    static void Main(string[] args)
    {

    }
    public int MajorityElement(int[] nums)
    {
        Dictionary<int,int> dict= new Dictionary<int,int>();
        foreach(int num in nums)
        {
            if(dict.ContainsKey(num)) dict[num]++;
            else dict[num] = 1;
            if (dict[num] > nums.Length/2) return num;
        }
        return -1;
    }
}