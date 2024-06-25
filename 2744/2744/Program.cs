class Program
{
    /*
     You are given a 0-indexed array words consisting of distinct strings.

    The string words[i] can be paired with the string words[j] if:

    The string words[i] is equal to the reversed string of words[j].
    0 <= i < j < words.length.
    Return the maximum number of pairs that can be formed from the array words.

    Note that each string can belong in at most one pair.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(MaximumNumberOfStringPairs(new string[] { "cd", "ac", "dc", "ca", "zz" }));
    }
    public static int MaximumNumberOfStringPairs(string[] words)
    {
        int count = 0;
        for (int i = 0;  i < words.Length;  i++)
        {
            for(int j = i+1; j<words.Length; j++)
            {
                if(words[i] == new string(words[j].Reverse().ToArray())) count++;
            }
        }
        return count;
    }
}