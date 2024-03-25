
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MostWordsFound(new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }));
    }
    /*
     A sentence is a list of words that are separated by a single space with no leading or trailing spaces.
    You are given an array of strings sentences, where each sentences[i] represents a single sentence.
    Return the maximum number of words that appear in a single sentence.
     */
    public static int MostWordsFound(string[] sentences)
    {
        int max = 0;
        foreach (string sentence in sentences)
        {
            int count = sentence.Trim().Split(' ').Count();
            if (count > max) max = count;
            count = 0;
        }
        return max;
    }
}
