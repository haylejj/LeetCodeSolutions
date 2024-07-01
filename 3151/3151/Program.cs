class Program
{
    /*
     An array is considered special if every pair of its adjacent elements contains two numbers with different parity.

    You are given an array of integers nums. Return true if nums is a special array, otherwise, return false.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(IsArraySpecial(new int[] {2,1,4}));
    }
    public static bool IsArraySpecial(int[] nums)
    {
        //2,1,4
        for(int i = 0; i<nums.Length-1; i++)
        {
            if (nums[i]%2 == nums[i+1]%2)          
                return false;  
        }
        return true;
    }
}