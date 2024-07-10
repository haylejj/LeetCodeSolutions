class Program
{
    static void Main(string[] args)
    {

    }
    public bool HasTrailingZeros(int[] nums)
    {
        int even = 0;
        foreach(var num in nums)
        {
            if (num%2==0)
                even++;
        }
        return even>=2;
    }
}