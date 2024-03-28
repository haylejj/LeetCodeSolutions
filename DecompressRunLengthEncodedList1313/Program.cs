class Program
{
    static void Main(string[] args)
    {
        foreach (var item in DecompressRLElist(new int[] { 1, 1, 2, 3 }))
        {
            Console.Write(item+" ");
        }
    }
    /*
     We are given a list nums of integers representing a list compressed with run-length encoding.

    Consider each adjacent pair of elements [freq, val] = [nums[2*i], nums[2*i+1]] (with i >= 0). 
    For each such pair, there are freq elements with value val concatenated in a sublist. 
    Concatenate all the sublists from left to right to generate the decompressed list.

    Return the decompressed list.
     */
    public static int[] DecompressRLElist(int[] nums)
    {
        List<int> result = new List<int>();

        int n=nums.Length/2;

        for(int i = 0;i < n; i++)
        {
            for(int j=0;j < nums[2*i]; j++)
            {
                result.Add(nums[(2*i)+1]);
            }
        }

        return result.ToArray();
    }
}