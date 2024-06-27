class Program
{
    /*
     You are given an array rectangles where rectangles[i] = [li, wi] represents the ith rectangle of length li and width wi.

    You can cut the ith rectangle to form a square with a side length of k if both k <= li and k <= wi. For example, if you have a rectangle [4,6], you can cut it to get a square with a side length of at most 4.

    Let maxLen be the side length of the largest square you can obtain from any of the given rectangles.

    Return the number of rectangles that can make a square with a side length of maxLen.
     */
    static void Main(string[] args)
    {
        int[][] rectangles = new int[][] { new int[] { 5, 8 }, new int[] { 3, 9 }, new int[] { 5, 12 }, new int[] { 16, 5 } };
        Console.WriteLine(CountGoodRectangles(rectangles));
    }
    public static int CountGoodRectangles(int[][] rectangles)
    {
        List<int> list = new List<int>();
        foreach (var item in rectangles)
        {
            if (item[0]>=item[1])
            {
                list.Add(item[1]);
            }
            else
            {
                list.Add(item[0]);
            }
        }
        //int maxLength = 0;
        //int count = 0;
        //foreach (var item in list)
        //{
        //    if (maxLength==Math.Pow(item, 2)) count++;
        //    var temp=(int)Math.Pow(item, 2);
        //    if (temp>maxLength) { maxLength = temp; count = 1;}
        //}
        int count = 0;
        int maxLength = list.Max();
        foreach (var item in list)
        {
            if (item==maxLength)
            {
                count++;
            }
        }
        return count;
    }
}