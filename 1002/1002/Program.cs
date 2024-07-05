using System.Collections;

class Program
{
    /*
     Given a string array words, return an array of all characters that show up in all strings within the words (including duplicates). 
     You may return the answer in any order
     */
    static void Main(string[] args)
    {
        Console.WriteLine(CommonChars(new string[] { "bella", "label", "roller" }));
    }
    public static IList<string> CommonChars(string[] words)
    {
        //"bella","label","roller"
        List<string> result = new List<string>();
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (var c in words[0])
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }
        for (int i = 1; i < words.Length; i++)
        {
            Dictionary<char, int> temp = new Dictionary<char, int>();
            foreach (var c in words[i])
            {
                if (temp.ContainsKey(c))
                {
                    temp[c]++;
                }
                else
                {
                    temp.Add(c, 1);
                }
            }
            foreach (var item in dict)
            {
                if (temp.ContainsKey(item.Key))
                {
                    dict[item.Key] = Math.Min(dict[item.Key], temp[item.Key]);
                }
                else
                {
                    dict[item.Key] = 0;
                }
            }
        }
        foreach (var item in dict)
        {
            for (int i = 0; i < item.Value; i++)
            {
                result.Add(item.Key.ToString());
            }
        }
        return result;

    }
}