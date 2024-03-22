using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ContainsPattern(new int[] {1,2,4,4,4,4},1,3));
    }
    /*
    Given an array of positive integers arr, find a pattern of length m that is repeated k or more times.
    A pattern is a subarray (consecutive sub-sequence) that consists of one or more values, repeated multiple times consecutively without overlapping.
    A pattern is defined by its length and the number of repetitions.
    Return true if there exists a pattern of length m that is repeated k or more times, otherwise return false.
     */
    // 
    /*
     [1,2,4,4,4,4]
    m=1 k=3 it should be return true.
    k or more times but not less.
     */
    public static bool ContainsPattern(int[] arr, int m, int k)
    {
        int count = m;
        for(int i=0;i<arr.Length-m; i++)
        {
            if (arr[i] == arr[i + m])
            {
                count++;
            }
            else
            {
                count = m;
            }

            if (count / m >= k)
            {
                return true;
            }
        }
        return false;
    }
}
