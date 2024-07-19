class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SemiOrderedPermutation(new int[] { 2, 1, 4, 3 }));
    }
    public static int SemiOrderedPermutation(int[] nums)
    {
        int n = nums.Length;
        int nIndex = Array.IndexOf(nums, n);
        int oneIndex = Array.IndexOf(nums, 1);
        int countOperation = 0;
        if (oneIndex>nIndex) return oneIndex+n-nIndex-2;
        else return oneIndex+n-nIndex-1;
    }
}