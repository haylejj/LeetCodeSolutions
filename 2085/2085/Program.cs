using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CountWords(new string[] { "leetcode", "is", "amazing", "as", "is" },new string[] { "amazing", "leetcode", "is" }));
    }
    public static  int CountWords(string[] words1, string[] words2)
    {
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        Dictionary<string, int> keyValuePairs2 = new Dictionary<string, int>();
        foreach (var word in words1)
        {
            if (keyValuePairs.ContainsKey(word))
                keyValuePairs[word]++;
            else
                keyValuePairs[word]=1;
        }
        foreach (var word in words2)
        {
            if (keyValuePairs2.ContainsKey(word))
                keyValuePairs2[word]++;
            else
                keyValuePairs2[word]=1;
        }
        int count = 0;
        foreach (var word in keyValuePairs)
        {
            if (word.Value==1 && keyValuePairs2.ContainsKey(word.Key )&& keyValuePairs2[word.Key]==1)
                count++;
        }
        return count;
    }
}