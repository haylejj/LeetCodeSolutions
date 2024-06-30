class Program
{
    /*
     Given an integer array nums, return the greatest common divisor of the smallest number and largest number in nums.

    The greatest common divisor of two numbers is the largest positive integer that evenly divides both numbers.
     */
    static void Main(string[] args)
    {

    }
    public int FindGCD(int[] nums)
    {
        int max= nums.Max();
        int min= nums.Min();
        int gcd = 0;
        for(int i = 1; i<=min; i++)
        {
            if (min%i==0 && max%i==0)
            {
                if (i>gcd)
                {
                    gcd = i;
                }
            }
        }
        return gcd;
        
    }
    
}