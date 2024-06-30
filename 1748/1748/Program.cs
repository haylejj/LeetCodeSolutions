class Program
{
    /*
     You are given an integer array nums. The unique elements of an array are the elements that appear exactly once in the array.

    Return the sum of all the unique elements of nums.
     */
    static void Main(string[] args)
    {

    }
    public int SumOfUnique(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num]=1;
            }
        }
        int sum = 0;
        foreach(var item in dict)
        {
            if (item.Value==1)
            {
                sum+=item.Key;
            }
        }
        return sum;
    }
}