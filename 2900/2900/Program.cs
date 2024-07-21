class Program
{
    static void Main(string[] args)
    {

    }
    public IList<string> GetLongestSubsequence(string[] words, int[] groups)
    {
        List<string> result = new List<string>();
        result.Add(words[0]);
        var selected=groups[0];
        for(int i = 1; i<groups.Length; i++)
        {
            if (selected!=groups[i])
            {
                result.Add(words[i]);
                selected = groups[i];
            }
            
        }
        return result;
    }
}