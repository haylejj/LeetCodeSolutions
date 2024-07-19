class Program
{
    static void Main(string[] args)
    {
    }
    public int CountPrefixSuffixPairs(string[] words)
    {
        int count = 0;
        for(int i = 0; i<words.Length; i++)
        {
            for(int j = i+1; j<words.Length; j++)
                if (isPrefixAndSuffix(words[i], words[j])) count++;
        }
        return count;
    }
    private bool isPrefixAndSuffix(string str1, string str2) => str2.StartsWith(str1) && str2.EndsWith(str1);
}