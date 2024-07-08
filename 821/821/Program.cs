class Program
{
    static void Main()
    {

    }
    public int[] ShortestToChar(string s, char c)
    {
        int[] result=new int[s.Length];
        List<int> list = new List<int>();
        for (int i = 0; i < s.Length; i++)
            if (s[i]==c) list.Add(i);
        
        for (int i = 0; i < s.Length; i++)
        {
            var min= int.MaxValue;
            for(int k = 0; k<list.Count; k++)
            {
                min=Math.Min(min, Math.Abs(i-list[k]));
            }
            result[i]=min;
        }
        return result;
    }
}