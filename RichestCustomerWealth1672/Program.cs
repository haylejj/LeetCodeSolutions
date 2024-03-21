class Program
{
    static void Main(string[] args)
    {
        int[][] numbers = new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } };
        Console.WriteLine(MaximumWealth(numbers));
    }

    /*
        You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i ​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​ th​​​​ bank. 
        Return the wealth that the richest customer has.
        A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.
     */
    public static int MaximumWealth(int[][] accounts)
    {
        
        int maxWealth = 0;
        int sum = 0;
        for(int i=0;i<accounts.Length; i++)
        {
            for (int j=0; j<accounts[i].Length; j++) 
            {
                sum += accounts[i][j];
            }
            if (sum>maxWealth)
            {
                maxWealth = sum;
            }
            sum= 0;
            
        }
        return maxWealth;
    }
}
