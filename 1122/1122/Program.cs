class Program
{
    /*
     Given two arrays arr1 and arr2, the elements of arr2 are distinct, and all elements in arr2 are also in arr1.

    Sort the elements of arr1 such that the relative ordering of items in arr1 are the same as in arr2. 
    Elements that do not appear in arr2 should be placed at the end of arr1 in ascending order.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(RelativeSortArray(new int[] { 2, 21, 43, 38, 0, 42, 33, 7, 24, 13, 12, 27, 12, 24, 5, 23, 29, 48, 30, 31 },new int[] { 2, 42, 38, 0, 43, 21 }));
    }
    public static int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (var item in arr1)
        {
            if (dict.ContainsKey(item))
            {
                dict[item]++;
            }
            else
            {
                dict[item] = 1;
            }
        }

        List<int> result = new List<int>();

        foreach (var item in arr2)
        {
            if (dict.ContainsKey(item))
            {
                int count = dict[item];
                while (count > 0)
                {
                    result.Add(item);
                    count--;
                }
                dict.Remove(item);
            }
        }

        List<int> remaining = new List<int>(dict.Keys);
        remaining.Sort();
        foreach (var item in remaining)
        {
            int count = dict[item];
            while (count > 0)
            {
                result.Add(item);
                count--;
            }
        }

        return result.ToArray();
    }
}