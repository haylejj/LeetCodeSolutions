class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(BuyChoco(new int[] { 98, 54, 6, 34, 66, 63, 52, 39 }, 62));
    }
    public static int BuyChoco(int[] prices, int money)
    {
        var tempMoney = money;
        if (prices.Min()>=money) return money;
        int sum = 0; int count = 0;
        int j,selected;
        for(int i = 1; i<prices.Length; i++)
        {
            selected= prices[i];
            for(j=i-1; j>=0 && prices[j]>selected; j--)
                prices[j+1]= prices[j];
            prices[j+1]= selected;
        }
        for (int i = 0; i < 2; i++)
        {
            money -= prices[i];
            if (money == 0 && i == 1) break;
        }
        if (money >= 0) return money;
        return tempMoney;

    }
}