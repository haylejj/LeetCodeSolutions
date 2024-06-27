class Program
{
    /*
     You are given an array nums consisting of positive integers.

    Return the total frequencies of elements in nums such that those elements all have the maximum frequency.

    The frequency of an element is the number of occurrences of that element in the array.

 
     */
    static void Main(string[] args)
    {
        int[] nums = { 10, 12, 11, 9, 6, 19, 11 };
        Console.WriteLine(MaxFrequencyElements(nums));
    }
    public static int MaxFrequencyElements(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i<nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict.Add(nums[i], 1);
            }
        }
        int maximumFrequency = dict.Values.Max();
        return dict.Where(x=>x.Value==maximumFrequency).Sum(x=>x.Value);
    }
}