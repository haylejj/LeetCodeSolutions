class Program
{
    static void Main(string[] args)
    {
        foreach (var item in NumberGame(new int[] {5,4,2,3}))
        {
            Console.Write(item+" ");
        }
    }
    /*
    You are given a 0-indexed integer array nums of even length and there is also an empty array arr. 
    Alice and Bob decided to play a game where in every round Alice and Bob will do one move. The rules of the game are as follows:
    Every round, first Alice will remove the minimum element from nums, and then Bob does the same.
    Now, first Bob will append the removed element in the array arr, and then Alice does the same.
    The game continues until nums becomes empty.
    Return the resulting array arr.
     */
    public static int[] NumberGame(int[] nums)
    {
        Array.Sort(nums);
        int temp = 0;
        for(int i=0;i<nums.Length;i+=2)
        {
            temp=nums[i];
            nums[i]=nums[i+1];
            nums[i+1]=temp;
        }
        return nums;
    }
}