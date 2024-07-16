class Program
{
    static void Main(string[] args)
    {
        LastVisitedIntegers(new int[] { -1, -1, 94, 56, -1, 32, -1, -1, -1 });
    }
    public static IList<int> LastVisitedIntegers(int[] nums)
    {
        List<int> seen = new List<int>();
        List<int> ans= new List<int>();
        int countMinusOne= 0;
        for(int i = 0; i<nums.Length; i++)
        {
            if (nums[i]>0) { seen.Insert(0,nums[i]);countMinusOne=0; }
            else
            {
                countMinusOne++;
                if (countMinusOne<=seen.Count) ans.Add(seen[countMinusOne-1]);
                else ans.Add(-1);
            }

        }
        return ans;
    }
}