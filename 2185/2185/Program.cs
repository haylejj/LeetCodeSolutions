class Program
{
    /*
     You are given an array of strings words and a string pref.

    Return the number of strings in words that contain pref as a prefix.

    A prefix of a string s is any leading contiguous substring of s.
     */
    static void Main(string[] args)
    {

    }
    public int PrefixCount(string[] words, string pref)
    {
        int count = 0;
        for(int i=0; i<words.Length; i++)
        {
            if(words[i].StartsWith(pref))
            {
                count++;
            }
        }
        return count;
    }
}