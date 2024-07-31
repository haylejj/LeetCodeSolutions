class Program
{
    static void Main(string[] args)
    {
        MinimumCost(new int[] { 6, 5, 7, 9, 2, 2 });
    }
    public static int MinimumCost(int[] cost)
    {
        int minCost = 0;
        int j, selected;
        for(int i = 1; i<cost.Length; i++)
        {
            selected = cost[i];
            for(j=i-1;j>=0 && cost[j]<selected; j--)
            {
                cost[j+1]= cost[j];
            }
            cost[j+1] = selected;
        }
        for (int i = 0; i<cost.Length;i++)
        {
            if ((i+1)%3!=0) minCost+=cost[i];
        }
        return minCost;
    }
}