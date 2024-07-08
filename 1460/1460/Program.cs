class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CanBeEqual(new int[] {2,3,1,4},new int[] { 2, 4, 1, 3 }));
    }
    public static bool CanBeEqual(int[] target, int[] arr)
    {
        int j, selected;
        for (int i = 1; i<target.Length; i++) 
        {
            selected=target[i];
            for(j=i-1;j>=0 && target[j]>selected; j--)
            {
                target[j+1]=target[j];
            }
            target[j+1]=selected;
        }
        int k, selected2;
        for (int i = 1; i<arr.Length; i++)
        {
            selected2=arr[i];
            for (k=i-1; k>=0 && arr[k]>selected2; k--)
            {
                arr[k+1]=arr[k];
            }
            arr[k+1]=selected2;
        }
        for (int i = 0; i<target.Length; i++)
        {
            if (target[i]!=arr[i])
            {
                return false;
            }
        }
        return true;
    }
}