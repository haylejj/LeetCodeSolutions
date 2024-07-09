using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CountCharacters(new string[] { "helllo", "world", "leetcode" }, "welldonehoneyr"));
    }
    public static int CountCharacters(string[] words, string chars)
    {
        int sumOfLength = 0;
        for (int i = 0; i < words.Length; i++)
        {
            bool isValidWord = true;
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            for (int j = 0; j < chars.Length; j++)
            {
                if (charCount.ContainsKey(chars[j]))
                {
                    charCount[chars[j]]++;
                }
                else
                {
                    charCount.Add(chars[j], 1);
                }
            }
            for (int j = 0; j < words[i].Length; j++)
            {
                if (!charCount.ContainsKey(words[i][j]))
                {
                    isValidWord = false;
                    break;
                }
                if(charCount[words[i][j]] == 0)
                {
                    isValidWord = false;
                    break;
                }
                charCount[words[i][j]]--;
            }
            if (isValidWord)
            {
                sumOfLength += words[i].Length;
            }
        }

        return sumOfLength;
    }
}
