class Program
{
    /*
     You are given a 0-indexed 2D integer array nums representing the coordinates of the cars parking on a number line. 
     For any index i, nums[i] = [starti, endi] where starti is the starting point of the ith car and endi is the ending point of the ith car.
     Return the number of integer points on the line that are covered with any part of a car.
     */
    static void Main(string[] args)
    {

    }
    public int NumberOfPoints(IList<IList<int>> nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (var item in nums)
        {
            var startPoint = item[0];
            var endPoint = item[1];

            for (int i = startPoint; i <= endPoint; i++)
                set.Add(i);
        }

        return set.Count;
    }
}