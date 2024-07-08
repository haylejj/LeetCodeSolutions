class Program
{
    static void Main(string[] args)
    {

    }
    public int MinCostToMoveChips(int[] position)
    {
        var evenCount = 0;
        foreach(var item in position)
        {
            evenCount+= item & 1;
        }
        return Math.Min(evenCount, position.Length-evenCount);
    }
}