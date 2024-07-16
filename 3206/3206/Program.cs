class Program
{
    static void Main(string[] args)
    {

    }
    public int NumberOfAlternatingGroups(int[] colors)
    {
        int n = colors.Length;
        int countAlternatingGroups = 0;
        for(int i = 0; i<n; i++)
        {
            var temp= colors[i];
            if (colors[(i+1)%n]!=temp && colors[(i-1+n)%n]!=temp) countAlternatingGroups++;
        }
        return countAlternatingGroups;
    }
}