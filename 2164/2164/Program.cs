using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        SortEvenOdd(new int[] { 36, 45, 32, 31, 15, 41, 9, 46, 36, 6, 15, 16, 33, 26, 27, 31, 44, 34 });
    }
    public static int[] SortEvenOdd(int[] nums)
    {
        PriorityQueue<int, int> odd = new PriorityQueue<int, int>();
        PriorityQueue<int,int> even= new PriorityQueue<int, int>();
        for(int m = 0; m<nums.Length; m++)
        {
            if (m%2==0) even.Enqueue(nums[m], nums[m]);
            else odd.Enqueue(nums[m], -nums[m]);
        }
        for(int i = 0; i<nums.Length; i++)
        {
            if(i%2==0) nums[i]=even.Dequeue();
            else nums[i]=odd.Dequeue();
        }
        return nums;
        
    }
}