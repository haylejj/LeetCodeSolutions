class Program
{
    static void Main(string[] args)
    {

    }
    public int AverageValue(int[] nums)
    {
        int sum = 0;
        int count = 0;
        foreach (int num in nums)
        {
            if(num % 6 ==0)
            {
                sum+=num;
                count++;
            } 
        }
        
        return count ==0 ? 0 : sum/count;
    }
}