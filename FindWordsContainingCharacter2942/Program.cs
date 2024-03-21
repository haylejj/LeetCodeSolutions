using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

class Program
{
    static void Main(string[] args)
    {
        foreach (var item in FindWordsContaining(new string[] { "abc", "bcd", "aaaa", "cbc" },'a'))
        {
            Console.Write("index ->> "+ item + " ");
        }
    }
    /*You are given a 0-indexed array of strings words and a character x.

    Return an array of indices representing the words that contain the character x.

    Note that the returned array may be in any order. */

    public static IList<int> FindWordsContaining(string[] words, char x)
    {
        List<int> result = new List<int>();

        for(int i = 0; i<words.Length; i++)
        {
            if (words[i].Contains(x))
                result.Add(i);
        }
        return result;
    }
}
