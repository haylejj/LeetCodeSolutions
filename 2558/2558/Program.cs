class Program
{
    static void Main(string[] args)
    {

    }
    public long PickGifts(int[] gifts, int k)
    {
        
        for(int i = 0; i<k; i++)
        {
            int maxNum = gifts.Max();
            var tempSqrt=Math.Sqrt(maxNum);
            var index=Array.IndexOf(gifts, maxNum);
            gifts[index]=(int)tempSqrt;
        }
        return gifts.Sum(x=> (long)x);

    }
}