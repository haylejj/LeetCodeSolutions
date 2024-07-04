class Program
{
    /*
     You are given an array of n strings strs, all of the same length.

    The strings can be arranged such that there is one on each line, making a grid.

    For example, strs = ["abc", "bce", "cae"] can be arranged as follows:
    abc
    bce
    cae
    You want to delete the columns that are not sorted lexicographically. In the above example (0-indexed), columns 0 ('a', 'b', 'c') and 2 ('c', 'e', 'e') are sorted, while column 1 ('b', 'c', 'a') is not, so you would delete column 1.

    Return the number of columns that you will delete.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(MinDeletionSize(new string[] { "cba", "daf", "ghi" }));
    }
    public static int MinDeletionSize(string[] strs)
    {
        int count = 0;
        for (int i = 0; i<strs[0].Length; i++)
        {
            for (int j = 0; j<strs.Length-1; j++)
            {
                if (strs[j+1][i] < strs[j][i])
                {
                    count++;
                    break;
                }
            }
        }
        return count;
    }
}