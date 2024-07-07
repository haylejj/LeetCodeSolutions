class Program
{
    static void Main(string[] args)
    {

    }
    public int MaximumValue(string[] strs)
    {
        int length = 0;
        for(int i = 0; i<strs.Length; i++)
        {
            if (strs[i].Any(char.IsAsciiLetter))
            {
                length= Math.Max(length, strs[i].Length);
            }
            else
            {
                length=Math.Max(length, int.Parse(strs[i]));
            }
        }
        return length;
    }
}