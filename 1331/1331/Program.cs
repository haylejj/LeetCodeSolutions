class Program
{
    static void Main(string[] args)
    {
        ArrayRankTransform(new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 });
    }
    public static int[] ArrayRankTransform(int[] arr)
    {
        int[] newArray=new int[arr.Length];
        Array.Copy(arr, newArray,arr.Length);
        Array.Sort(arr);
        Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
        int rank = 1;
        for(int i = 0; i<arr.Length; i++)
        {
            if(!keyValuePairs.ContainsKey(arr[i])) keyValuePairs[arr[i]]=rank++;
        }
        for(int i=0;i<arr.Length; i++)
        {
            newArray[i]=keyValuePairs[newArray[i]];
        }
        return newArray;
    }
}