class Program
{
    static void Main(string[] args)
    {
        var result = KidsWithCandies(new int[] { 2, 3, 5, 1, 3 },3);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
    /*
     There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.

    Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.

    Note that multiple kids can have the greatest number of candies.
     
     */

    public static  IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {

        int highest = candies.Max();

        List<bool> result = new List<bool>();
        foreach (var item in candies)
        {
            if(item+extraCandies>=highest)
                result.Add(true);
            else result.Add(false);
        }
        return result;
    }
}
