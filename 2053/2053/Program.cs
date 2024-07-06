class Program
{
    /*
     A distinct string is a string that is present only once in an array.

    Given an array of strings arr, and an integer k, return the kth distinct string present in arr. If there are fewer than k distinct strings, return an empty string "".

    Note that the strings are considered in the order in which they appear in the array.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(KthDistinct(new string[] { "a", "b", "a", "c" }, 2));
    }
    public static string KthDistinct(string[] arr, int k)
    {
        //LinkedList<string> set = new LinkedList<string>();
        //List<string> list = new List<string>();
        //foreach(var item in arr)
        //{
        //    if(!set.Contains(item) && !list.Contains(item)) set.AddLast(item);
        //    else
        //    {
        //        set.Remove(item);
        //        list.Add(item);
        //    }
        //}
        //if(set.Count < k) return "";
        //return set.ElementAt(k-1);
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (var item in arr)
        {
            if (dict.ContainsKey(item)) dict[item]++;
            else dict.Add(item, 1);
        }
        int dictinctCount = 0;
        foreach(var item in dict)
        {
            if (item.Value == 1) dictinctCount++;
            if (dictinctCount == k) return item.Key;
        }
        return "";
    }
}