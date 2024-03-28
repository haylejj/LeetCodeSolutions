class Program
{
    static void Main(string[] args)
    {
        Console.Write(ArrayStringsAreEqual(new string[] { "ab", "c" },new string[] {"a","bc"}));
    }
    /*
    Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.

    A string is represented by an array if the array elements concatenated in order forms the string.
     */
    public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        return string.Join("", word1).SequenceEqual(string.Join("", word2));
        
    }
}