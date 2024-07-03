class Program
{
    /*
     You are given a 0-indexed array mountain. Your task is to find all the peaks in the mountain array.

    Return an array that consists of indices of peaks in the given array in any order.

    Notes:

    A peak is defined as an element that is strictly greater than its neighboring elements.
    The first and last elements of the array are not a peak.
     */
    static void Main(string[] args)
    {

    }
    public IList<int> FindPeaks(int[] mountain)
    {
        //1,4,3,8,5
        List<int> result = new List<int>();
        for(int i=1;i<mountain.Length-1;i++)
        {
            if(mountain[i]>mountain[i-1] && mountain[i]>mountain[i+1])
            {
                result.Add(i);
            }
        }
        return result;
    }
}