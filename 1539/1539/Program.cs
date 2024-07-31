class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindKthPositive(new int[] { 5, 6, 7, 8, 9 },9));
    }
    public static int FindKthPositive(int[] arr, int k)
    {
        List<int> list = new List<int>();
        if (arr[0] != 1)
        {
            var num = arr[0]-1;
            while (num > 0)
            {
                list.Add(num--);
            }
        }
        for (int i = 0; i<arr.Length-1; i++)
        {
       
            if (arr[i+1]-arr[i] != 1)
            {
                var num = arr[i+1]-arr[i]-1;
                while (num > 0)
                {
                    list.Add(arr[i+1]-num--);
                }
            }

        }
        list.Sort();
        if (list.Count >= k) return list[k-1];
        return arr[arr.Length-1]+k-list.Count;
    }
}