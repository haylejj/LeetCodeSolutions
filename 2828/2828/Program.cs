class Program
{
    /*
      Given an array of strings words and a string s, determine if s is an acronym of words.

      The string s is considered an acronym of words if it can be formed by concatenating the first character of each string in words in order. For example, "ab" can be formed from ["apple", "banana"], but it can't be formed from ["bear", "aardvark"].

       Return true if s is an acronym of words, and false otherwise.
     */
    static void Main(string[] args)
    {
        //["ekin","f","rabj","driadwjqz"]
        Console.WriteLine(IsAcronym(new List<string> { "ekin", "f", "rabj", "driadwjqz" }, "defr")); // false
        Console.WriteLine(IsAcronym(new List<string> { "an", "apple" }, "a"));
    }
    public static bool IsAcronym(IList<string> words, string s)
    {
        for (int i = 0; i<s.Length; i++) 
        {   
            if(s.Length != words.Count) return false;

            if (s[i] != words[i][0]) 
            {
                return false;
            }
            
        }
        return true;
    }
}