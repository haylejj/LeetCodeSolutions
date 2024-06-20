class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SubsetXORSum(new int[] { 3, 4, 5, 6, 7, 8 }));
    }
    public static int SubsetXORSum(int[] nums)
    {
        return XorHelper(nums,0,0);
    }
    private static  int XorHelper(int[] nums,int index,int Xor)
    {
        if(index ==nums.Length)
        {
            return Xor;
        }
        return XorHelper(nums,index+1,Xor^nums[index])+XorHelper(nums,index+1,Xor);
    }
}
