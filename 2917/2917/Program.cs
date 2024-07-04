class Program
{
    /*
     You are given an integer array nums, and an integer k. Let's introduce K-or operation by extending the standard bitwise OR. In K-or, a bit position in the result is set to 1 if at least k numbers in nums have a 1 in that position.

    Return the K-or of nums.
     */
    static void Main(string[] args)
    {

    }
    public int FindKOr(int[] nums, int k)
    {
        int[][] arr = new int[nums.Length][];
        //binary koda çevirme işlemi Convert.ToString(num, 2); ile de yapılabilir.
        for (int i = 0; i < nums.Length; i++)
        {
            arr[i] = new int[32];
            int num = nums[i];
            for (int j = 31; j >= 0; j--)
            {
                arr[i][j] = num & 1;
                num >>= 1;
            }
        }

        for (int l = 31; l >= 0; l--)
        {
            int count = 0;
            for (int m = 0; m < arr.Length; m++)
            {
                if (arr[m][l] == 1)
                    count++;
            }

            if (count >= k)
            {
                for (int n = 0; n < arr.Length; n++)
                    arr[n][l] = 1;
            }
            else
            {
                for (int n = 0; n < arr.Length; n++)
                    arr[n][l] = 0;
            }
        }

        string resultBinary = string.Join("", arr[0]);
        int result = Convert.ToInt32(resultBinary,2);

        return result;
    }
}