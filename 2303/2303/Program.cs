class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CalculateTax(new int[][] {new int[] {10,10} },5));
    }
    public static double CalculateTax(int[][] brackets, int income)
    {
        if (income == 0) return 0;

        double tax = 0;

        // İlk vergi dilimini kontrol et
        if (brackets[0][0] >= income)
        {
            tax += brackets[0][1] * income * 0.01;
            return tax;
        }
        else
        {
            tax += brackets[0][0] * brackets[0][1] * 0.01;
            income -= brackets[0][0];
        }

        // Diğer vergi dilimlerini kontrol et
        for (int i = 1; i < brackets.Length; i++)
        {
            if (income <= 0) break;

            int bracketRange = brackets[i][0] - brackets[i - 1][0];

            if (income >= bracketRange)
            {
                tax += bracketRange * brackets[i][1] * 0.01;
                income -= bracketRange;
            }
            else
            {
                tax += income * brackets[i][1] * 0.01;
                break;
            }
        }

        return tax;
    }
}