class Program
{
    static void Main(string[] args)
    {

    }
    public IList<string> StringMatching(string[] words)
    {
        HashSet<string> result = new HashSet<string>();
        for (int i = 0; i<words.Length; i++)
        {
            for (int k = i+1; k<words.Length; k++)
            {
                if (words[i].Length>words[k].Length)
                {
                    if (words[i].Contains(words[k])) result.Add(words[k]);
                }
                else
                {
                    if (words[k].Contains(words[i])) result.Add(words[i]);
                }
            }
        }
        return result.ToList();
    }
}