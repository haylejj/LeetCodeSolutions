class Program
{
    static void Main(string[] args)
    {

    }
    public int MinStartValue(int[] nums)
    {
        int minValue = 0; 
        int stepSum = 0; 
        foreach (int num in nums)
        {
            stepSum += num;
            if (stepSum < minValue)
                minValue = stepSum;
        }
        return Math.Max(1, 1 - minValue);
    }
}