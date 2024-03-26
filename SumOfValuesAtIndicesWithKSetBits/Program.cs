class Program
{
    static void Main(string[] args)
    {
        Console.Write(SumIndicesWithKSetBits(new int[] { 4, 3, 2, 1 },2));
    }
    /*
     You are given a 0-indexed integer array nums and an integer k.
    Return an integer that denotes the sum of elements in nums whose corresponding indices have exactly k set bits in their binary representation.
    The set bits in an integer are the 1's present when it is written in binary.
    For example, the binary representation of 21 is 10101, which has 3 set bits.
     */
    public static int SumIndicesWithKSetBits(IList<int> nums, int k)
    {
        int sum = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            if (BinaryControl(i,k))
                sum += nums[i];
        }
        return sum;
    }
    public static bool BinaryControl(int num,int k)
    {
        //8/2=4 remain 0
        int count = 0;
        int remain = 0;
        while(num > 0)
        {
            remain=num%2;
            if(remain == 1) count++;
            num=num/2;
        }
        return count  == k;
    }
}
