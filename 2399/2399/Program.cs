class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CheckDistances("abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyyzza", new int[] { 49, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }));
    }
    public static bool CheckDistances(string s, int[] distance)
    {
        //Dictionary<char,int> dictionary = new Dictionary<char,int>();
        //foreach(var item in s)
        //{
        //    if(dictionary.ContainsKey(item)) dictionary[item]++;
        //    else dictionary[item] = 1;
        //}
        int diff = 0;
        bool checkStatus= false;
        for(int i = 0; i<s.Length; i++)
        {
            for(int j=i+1; j<s.Length; j++)
            {
                if (s[i]==s[j])
                {
                    diff=Math.Abs(i-j)-1;
                    if (distance[s[i]-'a']==diff) checkStatus = true;
                    else
                    {
                         checkStatus = false;
                        return checkStatus;
                    }
                }
            }
        }
        return checkStatus;
    }
}
