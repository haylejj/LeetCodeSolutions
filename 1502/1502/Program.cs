class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CanMakeArithmeticProgression(new int[] { 3, 5, 1 }));
    }
    public static bool CanMakeArithmeticProgression(int[] arr)
    {
        int j, selected;
        for(int i = 1; i<arr.Length; i++)
        {
            selected= arr[i];
            for(j=i-1; j>=0 && arr[j]>selected; j--)
            {
                arr[j+1]= arr[j];
            }
            arr[j+1]= selected;
        }
        int diff= arr[1]-arr[0];
        for(int i=2; i<arr.Length; i++)
        {
            if(arr[i]-arr[i-1]!=diff)
            {
                return false;
            }
        }
        return true;
    }
}