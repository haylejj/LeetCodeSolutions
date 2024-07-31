class Program
{
    /*
    "Flush": Five cards of the same suit.
    "Three of a Kind": Three cards of the same rank.
    "Pair": Two cards of the same rank.
    "High Card": Any single card.
     */
    static void Main(string[] args)
    {

    }
    public string BestHand(int[] ranks, char[] suits)
    {
        HashSet<char> suitMap= new HashSet<char>(suits);
        if (suitMap.Count==1) return "Flush";
        Dictionary<int,int> rankMap = new Dictionary<int,int>();
        foreach (int rank in ranks)
        {
            if (rankMap.ContainsKey(rank)) rankMap[rank]++;
            else rankMap[rank]=1;
        }
        bool aa=false;
        foreach (var item in rankMap.Keys)
        {
            if (rankMap[item] >= 3) return "Three of a Kind";
            else if (rankMap[item]==2) aa = true;
            
        }
        if (aa) return "Pair";
        return "High Card";
    }
}
