class Program
{
    /*
     * Given an array of strings words, return the first palindromic string in the array. If there is no such string, return an empty string "".

       A string is palindromic if it reads the same forward and backward.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(FirstPalindrome(new string[] { "abc", "car", "ada", "racecar", "cool" }));
    }
    public static string FirstPalindrome(string[] words)
    {
        for(int i = 0; i<words.Length; i++)
        {
            if (words[i]== new string(words[i].Reverse().ToArray()))
            {
                return words[i];
            }
        }
        return "";
    }
}
