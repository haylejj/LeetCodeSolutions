class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ResultArray(new int[] { 5, 4, 3, 8 }));
    }
    public static int[] ResultArray(int[] nums)
    {
        int[] arr1=new int[nums.Length];
        int[] arr2=new int[nums.Length];
        int operation = nums.Length;
        arr1[0]=nums[0];
        arr2[0]=nums[1];
        int m=0, j = 0;
        for(int i = 2; i<operation; i++)
        {
            if (arr1[m]> arr2[j]) {
                arr1[m+1]=nums[i];
                m++;
            }
            else
            {
                arr2[j+1]=nums[i];
                j++;
            }
        }
        return arr1.Concat(arr2).Where(x=>x!=0).ToArray();
    }
}