class Program
{
    static void Main(string[] args)
    {

    }
    public int MinimumOperations(int[] nums)
    {
        return nums.Where(x=> x % 3 !=0).Count();
    }
}