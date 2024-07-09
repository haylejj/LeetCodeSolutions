class Program
{
    static void Main(string[] args)
    {

    }
    public string[] FindWords(string[] words)
    {
        string[] americanAlpfabe=new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
        List<string> result = new List<string>();
        for(int i = 0; i<words.Length; i++)
        {
            HashSet<char> set = new HashSet<char>(words[i].ToLower());
            for(int j = 0; j<americanAlpfabe.Length; j++)
            {
                if (set.IsSubsetOf(americanAlpfabe[j])) result.Add(words[i]);
            }
        }
        return result.ToArray();
    }
}