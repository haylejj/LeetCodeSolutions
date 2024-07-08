class Program
{
    static void Main(string[] args)
    {

    }
    public string[] FindRelativeRanks(int[] score)
    {
        int n= score.Length;
        var temp = score.Clone() as int[];
        Array.Sort(score);
        string[] result = new string[n];
        for (int i = 0; i < n; i++)
        {
            int index = Array.IndexOf(score, score[i]);
            int index2= Array.IndexOf(temp, score[i]);
            if (index == n-1)
            {
                result[index2] = "Gold Medal";
            }
            else if (index == n-2)
            {
                result[index2] = "Silver Medal";
            }
            else if (index == n-3)
            {
                result[index2] = "Bronze Medal";
            }
            else
            {
                result[index2] = (n-index).ToString();
            }
        }
        return result;
    }
}