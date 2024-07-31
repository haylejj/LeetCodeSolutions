class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CountHillValley(new int[] {2,4,1,1,6,5}));
    }
    public static int CountHillValley(int[] nums)
    {
        int count = 0;
        var temp2=nums[0];
        for (int i = 1; i<nums.Length-1; i++)
        {
            var temp1 = nums[i];
            var temp3 = nums[i+1];

            if ((temp1 > temp2 && temp1 > temp3) || (temp1<temp2 && temp1< temp3))
            {
                count++;
                temp2=temp1;
            }
        }
        return count;


    }
}