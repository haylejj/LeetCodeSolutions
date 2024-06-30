using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(UniqueOccurrences(new int[] { 1, 2 }));
    }
    public static bool UniqueOccurrences(int[] arr)
    {
        Hashtable hash = new Hashtable();
        for(int i = 0; i<arr.Length; i++)
        {
            if (hash.ContainsKey(arr[i]))
            {
                hash[arr[i]]=(int)hash[arr[i]]+1;
            }
            else
            {
                hash.Add(arr[i], 1);
            }
        }
        foreach (var value1 in hash.Values)
        {
            int count = 0;
            foreach (var value2 in hash.Values)
            {
                if (value1.Equals(value2))
                {
                    count++;
                    if (count > 1)
                    {
                        return false; 
                    }
                }
            }
        }
        return true;
    }
}