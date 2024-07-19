class Program
{
    static void Main(string[] args)
    {

    }
    public bool FindSubarrays(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        for(int i = 0; i<nums.Length-1; i++)
        {
            var temp = nums[i]+nums[i+1];
            if(set.Contains(temp)) return true;
            set.Add(temp);
        }
        return false;
    }
}