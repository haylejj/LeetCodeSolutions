class Program
{
    /*
     You are given an integer array arr. 
    Sort the integers in the array in ascending order by the number of 1's in their binary representation 
    and in case of two or more integers have the same number of 1's you have to sort them in ascending order.

    Return the array after sorting it.
     */
    static void Main(string[] args)
    {
        foreach (var item in SortByBits(new int[] { 0,1,2,3,4,5,6,7,8 }))
        {
            Console.WriteLine(item+" ");
        }
    }
    public static int[] SortByBits(int[] arr)
    {
        Array.Sort(arr, (a, b) =>
        {
            var temp1=CountBits(a);
            var temp2=CountBits(b);
            if (temp1 == temp2)
            {
                return a.CompareTo(b);
            }
            return temp1.CompareTo(temp2);
        });
        
        return arr;
    }
    private static int CountBits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            count += number & 1;
            number >>= 1;
        }
        return count;
    }
}
