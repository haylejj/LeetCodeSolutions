class Program
{
    /*
     You are given an integer array nums containing positive integers. We define a function encrypt such that encrypt(x) replaces every digit in x with the largest digit in x. 
    For example, encrypt(523) = 555 and encrypt(213) = 333.

    Return the sum of encrypted elements.
     */
    static void Main(string[] args)
    {

    }
    public int SumOfEncryptedInt(int[] nums)
    {
        int sum = 0;
        for(int i = 0; i<nums.Length; i++)
        {
            nums[i] = Encrypt(nums[i]);
            sum+=nums[i];
        }
        return sum;
    }
    private int Encrypt(int x)
    {
        int len = x.ToString().Length;
        int max = 0;
        while (x>0)
        {
            max = Math.Max(max, x%10);
            x=x/10;
        }
        return int.Parse(string.Join("", Enumerable.Repeat(max.ToString(), len)));
    }
}