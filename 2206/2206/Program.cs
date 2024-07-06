class Program
{
    /*
     You are given an integer array nums consisting of 2 * n integers.

    You need to divide nums into n pairs such that:

    Each element belongs to exactly one pair.
    The elements present in a pair are equal.
    Return true if nums can be divided into n pairs, otherwise return false.
     */
    static void Main(string[] args)
    {

    }
    public bool DivideArray(int[] nums)
    {
        int n= nums.Length / 2;
        Array.Sort(nums);
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if (dic.ContainsKey(nums[i]))
                dic[nums[i]]++;
            else
                dic[nums[i]]=1;
        }
        foreach (var item in dic)
        {
            if (item.Value % 2 != 0)
            {
                return false;
            }
        }
        return true;
    }
}