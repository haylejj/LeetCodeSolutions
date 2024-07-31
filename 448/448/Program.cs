class Program
{
    static void Main(string[] args)
    {

    }
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        HashSet<int> result = new HashSet<int>(nums);
        List<int> list = new List<int>();

        for(int i = 0; i<nums.Length; i++)
        {
            if(!result.Contains(i+1)) list.Add(i+1); 
        }
        return list;
    }
}