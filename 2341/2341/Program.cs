class Program
{
    /*
     You are given a 0-indexed integer array nums. In one operation, you may do the following:
    Choose two integers in nums that are equal.
    Remove both integers from nums, forming a pair.
    The operation is done on nums as many times as possible.
    Return a 0-indexed integer array answer of size 2 where answer[0] is the number of pairs that are formed and answer[1] is the number of leftover integers in nums after doing the operation as many times as possible.
     */
    static void Main(string[] args)
    {

    }
    public int[] NumberOfPairs(int[] nums)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (var item in nums)
        {
            if (dic.ContainsKey(item))
            {
                dic[item]++;
            }
            else
            {
                dic.Add(item, 1);
            }
        }
        int pairs = 0;
        int left = 0;
        foreach (var item in dic)
        {
            pairs += item.Value / 2;
            left += item.Value % 2;
        }
        return new int[] { pairs, left };
    }
}