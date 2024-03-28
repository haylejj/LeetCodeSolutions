class Program
{
    static void Main(string[] args)
    {
        foreach (var item in CreateTargetArray(new int[] { 0,1,2,3,4,7 },new int[] {0,1,2,2,2,2}))
        {
            Console.Write(item+" ");
        }
    }
    /*
     Given two arrays of integers nums and index. Your task is to create target array under the following rules:

    Initially target array is empty.
    From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in target array.
    Repeat the previous step until there are no elements to read in nums and index.
    Return the target array.

    It is guaranteed that the insertion operations will be valid.
     */
    public static int[] CreateTargetArray(int[] nums, int[] index)
    {
        //int[] targetArr= new int[nums.Length];

        //for(int i = 0; i<nums.Length; i++)
        //{
        //    for(int j=nums.Length-1; j> index[i]; j--)
        //    {
        //        targetArr[j]=targetArr[j-1];
        //    }
        //    targetArr[index[i]]= nums[i];
        //}
        //return targetArr;
        List<int> list = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            list.Insert(index[i], nums[i]);
        }
        return list.ToArray();
    }
}