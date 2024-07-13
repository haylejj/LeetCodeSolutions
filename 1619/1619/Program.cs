class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(TrimMean(new int[] { 6, 0, 7, 0, 7, 5, 7, 8, 3, 4, 0, 7, 8, 1, 6, 8, 1, 1, 2, 4, 8, 1, 9, 5, 4, 3, 8, 5, 10, 8, 6, 6, 1, 0, 6, 10, 8, 2, 3, 4 }));
    }
    public static double TrimMean(int[] arr)
    {
        // sorting array using insertion sort
        int j, selected;
        for(int i = 1; i<arr.Length; i++)
        {
            selected=arr[i];
            for (j = i-1; j>=0 && arr[j]>selected;j--)
                arr[j+1]=arr[j];
            arr[j+1]=selected;
        }
        int percent = (5*arr.Length)/100;
        double sum = 0;
        for (int i = percent; i<arr.Length-percent; i++)
        {
            sum+=arr[i];
        }
        return sum/(arr.Length-(2*percent));
    }
}