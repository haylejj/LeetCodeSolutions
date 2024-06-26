
class Program
{
    /*
    Given an array of positive integers nums, return an array answer that consists of the digits of each integer in nums 
     
    after separating them in the same order they appear in nums.

    To separate the digits of an integer is to get all the digits it has in the same order.

    For example, for the integer 10921, the separation of its digits is [1,0,9,2,1].
 
     */
    static void Main(string[] args)
    {

    }
    public int[] SeparateDigits(int[] nums)
    {
        List<int> list = new List<int>();
        List<int> list2 = new List<int>();
        int count = 0;

        for (int i = 0; i<nums.Length; i++) 
        {
            if (nums[i]<10) list.Add(nums[i]);
            //13 250/10
            else
            {
                while (nums[i]>0)
                {
                    list.Add(nums[i] % 10);
                    nums[i] /= 10;
                }
            }
            list.Reverse();
            list2.AddRange(list);
            list.Clear();
        }
        return list2.ToArray();
    }
}