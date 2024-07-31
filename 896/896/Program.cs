class Program
{
    static void Main(string[] args)
    {

    }
    public bool IsMonotonic(int[] nums)
    {
        bool a= true;
        bool b= true;
        for(int i = 0; i < nums.Length-1; i++)
        {
            if(nums[i] < nums[i+1]) a= false;
            else if(nums[i] > nums[i+1]) b= false;
        }
        return a || b;
    }
}