class Program
{
    static void Main(string[] args)
    {

    }
    public double Average(int[] salary)
    {
        return (double)(salary.Sum()-salary.Min()-salary.Max())/(salary.Length-2);
    }
}