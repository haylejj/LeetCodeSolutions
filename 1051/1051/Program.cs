class Program
{
    /*
     A school is trying to take an annual photo of all the students. The students are asked to stand in a single file line in non-decreasing order by height. Let this ordering be represented by the integer array expected where expected[i] is the expected height of the ith student in line.

    You are given an integer array heights representing the current order that the students are standing in. Each heights[i] is the height of the ith student in line (0-indexed).

    Return the number of indices where heights[i] != expected[i].
     */
    static void Main(string[] args)
    {

    }
    public int HeightChecker(int[] heights)
    {
        int[] expected = new int[heights.Length];
        Array.Copy(heights, expected, heights.Length);
        BubbleSort(expected);
        int count = 0;
        for(int i = 0; i<heights.Length; i++)
        {
            if(heights[i]!=expected[i]) count++;
        }
        return count;
    }
    private static void BubbleSort(int[] arr)
    {
        for(int i = 0; i<arr.Length-1; i++)
        {
            for(int j = 0; j<arr.Length-i-1; j++)
            {
                if (arr[j]>arr[j+1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }
}
