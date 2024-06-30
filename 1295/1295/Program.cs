class Program
{
    /*
     Given an array nums of integers, return how many of them contain an even number of digits.
     */
    static void Main(string[] args)
    {
    }
    public int FindNumbers(int[] nums)
    {
        int count = 0;
        foreach (var item in nums)
        {
            if (item.ToString().Length%2 ==0) count++;
        }
        return count;
    }
}