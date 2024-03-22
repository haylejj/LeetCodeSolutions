class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DiagonalPrime(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }));
    }

    /*
        You are given a 0-indexed two-dimensional integer array nums.

        Return the largest prime number that lies on at least one of the diagonals of nums. In case, no prime is present on any of the diagonals, return 0.

        Note that:

        An integer is prime if it is greater than 1 and has no positive integer divisors other than 1 and itself.
        An integer val is on one of the diagonals of nums if there exists an integer i for which nums[i][i] = val or an i for which nums[i][nums.length - i - 1] = val.

    */
    public static int DiagonalPrime(int[][] nums)
    {
        List<int> result= new List<int>();
        for(int i = 0; i<nums.Length; i++)
        {
            for(int j = 0; j<nums[i].Length; j++)
            {
                if (i == j || i + j == nums.Length - 1)
                {
                    result.Add(nums[i][j]);
                }
            }
        }
        int highest = 0;
        foreach (var item in result)
        {
            if(item > highest && isPrime(item))
                highest = item;
        }
        return highest;

    }
    public static bool isPrime(int num)
    {
        if (num < 2) return false;
        for(int i = 2; i*i<=num; i++)
        {
            if(num % i == 0) return false;
            
        }
        return true;
    }

}