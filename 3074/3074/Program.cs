class Program
{
    static void Main(string[] args)
    {

    }
    public int MinimumBoxes(int[] apple, int[] capacity)
    {
        int sumOfApple= apple.Sum();
        int j, selected;
        //sorting using insertion algorithm
        for(int i = 1; i<capacity.Length; i++)
        {
            selected = capacity[i];
            for(j=i-1;j>=0 && capacity[j]<selected;j--)
                capacity[j+1]= capacity[j];
            capacity[j+1]=selected;
        }
        int sumOfCapacity = 0;
        int count = 0;
        foreach(var item in capacity)
        {
            sumOfCapacity+=item; count++;
            if(sumOfCapacity>=sumOfApple) break;
        }
        return count;
    }
}