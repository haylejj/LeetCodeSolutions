class Program
{
    static void Main(string[] args)
    {
        foreach (var item in Shuffle(new int[] { 2, 5, 1, 3, 4, 7 },3))
        {
            Console.Write(item+" ");
        }
    }
    //Given the array nums consisting of 2n elements in the form[x1, x2, ..., xn, y1, y2, ..., yn].
    //Return the array in the form[x1, y1, x2, y2, ..., xn, yn].
    public static int[] Shuffle(int[] nums, int n)
    {
        int k = 0;
        int[] result = new int[2*n];
        for (int i = 0; i<n; i++ )
        {
            result[k++] = nums[i];
            result[k++] = nums[i+n];
            
        }
        return result;
    }
}
