using System.Text;

class Program
{
    /*
     You are given a string s and an integer array indices of the same length. The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
    Return the shuffled string.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(RestoreString("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 }));
    }
    public static string RestoreString(string s, int[] indices)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i<s.Length; i++)
        {
            for (int j = 0; j<indices.Length; j++)
            {
                if (indices[j] == i)
                {
                    stringBuilder.Append(s[j]);
                }
            }
        }
        return stringBuilder.ToString();
    }
}