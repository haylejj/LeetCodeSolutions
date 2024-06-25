class Program
{
    /*
     Given an array of integers arr, and three integers a, b and c. You need to find the number of good triplets.

    A triplet (arr[i], arr[j], arr[k]) is good if the following conditions are true:

    0 <= i < j < k < arr.length
    |arr[i] - arr[j]| <= a
    |arr[j] - arr[k]| <= b
    |arr[i] - arr[k]| <= c
Where |x| denotes the absolute value of x.

Return the number of good triplets.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(CountGoodTriplets(new int[] { 3, 0, 1, 1, 9, 7 },7,2,3));
    }
    public static int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int count = 0;
        for(int i=0; i<arr.Length; i++)
        {
            for(int j = i+1; j<arr.Length; j++)
            {
                for(int k = j+1; k<arr.Length; k++)
                {
                    if (Math.Abs(arr[i]-arr[j]) <=a && Math.Abs(arr[j]-arr[k]) <= b && Math.Abs(arr[i]-arr[k]) <= c)
                        count++;
                }
            }
        }
        return count;
    }
}