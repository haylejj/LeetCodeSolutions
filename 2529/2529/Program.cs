class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MaximumCount(new int[] { -1924, -1910, -1840, -1797, -1714, -1640, -1638, -1567, -1564, -1409, -1141, -1115, -1068, -658, -465, -447, -434, -386, -321, -191, -186, -127, -63, 69, 186, 253, 334, 401, 482, 805, 809, 812, 833, 913, 955, 991, 1113, 1128, 1133, 1178, 1204, 1570, 1616, 1725, 1729, 1787, 1853, 1943, 1980, 1980 }));
    }
    public static int MaximumCount(int[] nums)
    {
        Dictionary<int,int> set=new Dictionary<int,int>();
        foreach(var num in nums)
        {
            if(set.ContainsKey(num)) set[num]++;
            else set[num]=1;
        }
        int negative = 0;
        int positive = 0;
        foreach(var num in nums)
        {
            if(num<0) negative++;
            else if(num>0) positive++;
        }
        return Math.Max(negative,positive);
    }
}