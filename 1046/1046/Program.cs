using Microsoft.VisualBasic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 }));
    }
    public static int LastStoneWeight(int[] stones)
    {
        if (stones.Length==1) return stones[0];
        int n=stones.Length;
                    
        while (n>1)
        {
            Array.Sort(stones);
            var max1=stones[n-1];
            var max2=stones[n-2];
            if (max1==max2)
            {
                stones[n-1]=0;
                stones[n-2]=0;
                n-=2;
            }
            else
            {
                stones[n-1]=0;
                stones[n-2]=max1-max2;
                n--;
            }
            stones=stones.Where(x => x!=0).ToArray();
            
        }
        if (n==1) return stones[0]; else return 0;

    }
}