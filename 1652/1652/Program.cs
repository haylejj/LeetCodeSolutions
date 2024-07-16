class Program
{
    /*
     * You have a bomb to defuse, and your time is running out! Your informer will provide you with a circular array code of length of n and a key k.

To decrypt the code, you must replace every number. All the numbers are replaced simultaneously.

If k > 0, replace the ith number with the sum of the next k numbers.
If k < 0, replace the ith number with the sum of the previous k numbers.
If k == 0, replace the ith number with 0.
As code is circular, the next element of code[n-1] is code[0], and the previous element of code[0] is code[n-1].

Given the circular array code and an integer key k, return the decrypted code to defuse the bomb!
     */
    static void Main(string[] args)
    {
        Console.WriteLine(Decrypt(new int[] { 5, 7, 1, 4 },-3));
    }
    public static int[] Decrypt(int[] code, int k)
    {
        int n = code.Length;
        int[] result = new int[n];
        if (k == 0)
        {
            Array.Fill(code, 0);
            return code;
        }
        else if (k>0)
        {
            for (int i = 0; i<n; i++)
            {
                var tempSum = 0;
                for (int j = 0; j<k; j++)
                    tempSum+=code[(i+j+1)%n];
                result[i]=tempSum;
            }
            return result;
        }
        else
        {
            for (int i = 0; i<n; i++)
            {
                var tempSum = 0;
                for (int j = 1; j<=-k; j++)
                    tempSum+=code[(i-j+n)%n];
                result[i]=tempSum;
            }
            return result;
        }

    }
}