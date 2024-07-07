class Program
{
    /*
     You are given a string array words and a string s, where words[i] and s comprise only of lowercase English letters.

    Return the number of strings in words that are a prefix of s.

    A prefix of a string is a substring that occurs at the beginning of the string. A substring is a contiguous sequence of characters within a string.
     */
    static void Main(string[] args)
    {

    }
    public int CountPrefixes(string[] words, string s)
    {
        int count = 0;
        foreach(var item in words)
        {
            if(s.StartsWith(item))
                count++;
        }
        return count;
    }
}