class Program
{
    /*
     * You are given a string allowed consisting of distinct characters and an array of strings words. A string is consistent if all characters in the string appear in the string allowed.

    Return the number of consistent strings in the array words.
     */
    static void Main(string [] args)
    {
        Console.WriteLine(CountConsistentStrings("ab",new string[] { "a", "bd", "aaab", "baa", "badab" }));
    }
    public static int CountConsistentStrings(string allowed, string[] words)
    {
        int count = 0;

        foreach (var item in words)
        {
            bool isConsistent = true;
            foreach (var ch in item)
            {
                if (!allowed.Contains(ch))
                {
                    isConsistent = false;
                    break;
                }
            }
            if(isConsistent) count++;
        }
        return count;
    }
}