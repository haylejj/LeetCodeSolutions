class Program
{
    static void Main(string[] args)
    {
        foreach (var item in LeftRightDifference(new int[] {10,4,8,3}))
        {
            Console.Write(item+" ");
        }
    }
    /*
     Given a 0-indexed integer array nums, find a 0-indexed integer array answer where:

    answer.length == nums.length.
    answer[i] = |leftSum[i] - rightSum[i]|.
    Where:

    leftSum[i] is the sum of elements to the left of the index i in the array nums. If there is no such element, leftSum[i] = 0.
    rightSum[i] is the sum of elements to the right of the index i in the array nums. If there is no such element, rightSum[i] = 0.
    Return the array answer.
     */
    public static int[] LeftRightDifference(int[] nums)
    {
        int[] result = new int[nums.Length];
        for(int i=0; i<nums.Length; i++)
        {
            result[i]=Math.Abs(nums.Take(i).Sum() - nums.Skip(i+1).Sum());
        }
        return result;
    }
}