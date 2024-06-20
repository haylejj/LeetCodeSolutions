class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MinMovesToSeat(new int[] { 2, 2, 6, 6 },new int[] { 1, 3, 2, 6 }));
    }
    public static int MinMovesToSeat(int[] seats, int[] students)
    {
        int movesSum = 0;
        Array.Sort(seats);
        Array.Sort(students);
        for(int i = 0; i<seats.Length; i++)
        {
           movesSum += Math.Abs(seats[i] - students[i]);
        }
        return movesSum;
    }
}
