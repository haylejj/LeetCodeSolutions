class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindEvenNumbers(new int[] { 2, 1, 3, 0 }));
    }
    public static int[] FindEvenNumbers(int[] digits)
    {
        HashSet<int> result = new HashSet<int>();
        for(int i=0;i<digits.Length; i++)
        {   
            if(digits[i] != 0)
            {
                for (int j = 0; j<digits.Length; j++)
                {
                    for(int k = 0; k<digits.Length; k++)
                    {
                        if(i != j &&  i != k && j !=k)
                        {
                            var tempNum = digits[i]*100+ digits[j]*10+ digits[k];
                            if(tempNum % 2 ==0) result.Add(tempNum);
                        }
                    }
                }
            }
        }
        return result.Order().ToArray();
    }
}