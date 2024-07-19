class Program
{
    static void Main(string[] args)
    {

    }
    public int ArraySign(int[] nums)
    {
        return signFunc(nums);
    }
    private int signFunc(int[] product)
    {
        int countMinus = 0;
        int countPlus = 0;
        for(int i = 0; i<product.Length; i++)
        {
            if (product[i] > 0) countPlus++;
            else if (product[i] < 0) countMinus++;
            else return 0;
        }
        return countMinus%2 == 0 ? 1 : -1;
    }
}