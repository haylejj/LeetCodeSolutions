class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(AnswerQueries(new int[] { 736411, 184882, 914641, 37925, 214915 },new int[] { 331244, 273144, 118983, 118252, 305688, 718089, 665450 }));
    }
    public static int[] AnswerQueries(int[] nums, int[] queries)
    {
        int[] result=new int[queries.Length];
        int j, selected;
        // sort the nums array
        for(int i = 1; i<nums.Length; i++)
        {
            selected= nums[i];
            for(j=i-1;j>=0 && nums[j]>selected; j--)
            {
                nums[j+1]=nums[j];
            }
            nums[j+1]=selected;
        }
        List<int> list = new List<int>();
        list.Add(nums[0]);
        for(int i = 0; i<queries.Length; i++)
        {
            for(int k = i+1; k<nums.Length; k++)
            {
                list.Add(nums[k]);
                if(list.Sum() <= queries[i]) { result[i]=k+1; break; }
            }
            list.RemoveRange(i+1, list.Count-(i+1));
        }
        return result;
    }
}