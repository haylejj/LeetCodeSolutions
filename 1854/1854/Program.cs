class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MaximumPopulation(new int[][] {new int[] { 1950, 1961 }, new int[] { 1960, 1971 }, new int[] { 1970, 1981 }}));
    }
    public static int MaximumPopulation(int[][] logs)
    {
        Dictionary<int,int> map= new Dictionary<int,int>();
        for(int i=0;i<logs.Length; i++)
        {
            if (!map.ContainsKey(logs[i][0])) map[logs[i][0]]=0;
            map[logs[i][0]]++;
            if(!map.ContainsKey(logs[i][1])) map[logs[i][1]]=0;
            map[logs[i][1]]--;
        }
        List<int> years= new List<int>(map.Keys);
        years.Sort();
        int maxPopulation = 0;
        int currentPopulation = 0;
        int earliestYear = 0;
        foreach (var year in years)
        {
            currentPopulation += map[year];
            if (currentPopulation > maxPopulation)
            {
                maxPopulation = currentPopulation;
                earliestYear = year;
            }
        }
        return earliestYear;
    }
}