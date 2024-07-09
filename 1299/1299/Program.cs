class Program
{
    static void Main(string[] args)
    {

    }
    public int[] ReplaceElements(int[] arr)
    {
        int[] result=new int[arr.Length];
        if (arr.Length==1) return new int[] { -1 };
        result[arr.Length-1]=-1;
        for(int i = 0; i<arr.Length-1; i++)
        {
            var max=int.MinValue;
            for(int j = i+1; j<arr.Length; j++)
            {
                max=Math.Max(max,arr[j]);
            }
            result[i]=max;
        }
        return result;
    }
}