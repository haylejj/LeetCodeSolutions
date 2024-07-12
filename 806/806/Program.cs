class Program
{
    static void Main(string[] args)
    {

    }
    public int[] NumberOfLines(int[] widths, string s)
    {
        int count = 0;
        int sum = 0;
        for(int i = 0; i<s.Length; i++)
        {
            int index= s[i] - 'a';
            sum += widths[index];
            if(sum > 100)
            {
                count++;
                sum = widths[index];
            }
        }
        return new int[]{count+1, sum};
    }
}