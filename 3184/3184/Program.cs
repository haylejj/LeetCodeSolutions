class Program
{
    /*
     Given an integer array hours representing times in hours, return an integer denoting the number of pairs i, j where i < j and hours[i] + hours[j] forms a complete day.

    A complete day is defined as a time duration that is an exact multiple of 24 hours.

    For example, 1 day is 24 hours, 2 days is 48 hours, 3 days is 72 hours, and so on.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(CountCompleteDayPairs(new int[] { 12, 12, 30, 24, 24 }));
    }
    public static int CountCompleteDayPairs(int[] hours)
    {
        // 1,2,3,4,5
        int count = 0;
        for(int i = 0; i<hours.Length; i++)
        {
            for(int j = i+1; j<hours.Length; j++)
            {
                if ((hours[i]+hours[j]) % 24 == 0) count++;
            }
        }
        return count;
    }

}