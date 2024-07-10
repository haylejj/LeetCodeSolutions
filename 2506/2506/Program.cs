class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SimilarPairs(new string[] { "aba", "aabb", "abcd", "bac", "aabc" }));
    }
    public static int SimilarPairs(string[] words)
    {
        int count = 0;
        for (int i = 0; i < words.Length - 1; i++)
        {
            HashSet<char> set = new HashSet<char>(words[i]);
            for (int j = i + 1; j < words.Length; j++)
            {
                HashSet<char> set2 = new HashSet<char>(words[j]);
                if (set.SetEquals(set2))
                {
                    count++;
                }
            }
        }
        return count;
    }
}