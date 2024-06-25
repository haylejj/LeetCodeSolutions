class Program
{
    /*
     You are given an array of strings names, and an array heights that consists of distinct positive integers. Both arrays are of length n.

    For each index i, names[i] and heights[i] denote the name and height of the ith person.

    Return names sorted in descending order by the people's heights.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(SortPeople(new string[] { "Mary", "John", "Emma" },new int[] { 180, 165, 170 }));
    }
    public static string[] SortPeople(string[] names, int[] heights)
    {
        //["Mary","John","Emma"]
        //[180,165,170]
        //mary 180
        //john 165
        //emma 170

        Dictionary<int, string> dict = new Dictionary<int, string>();
        for (int i = 0; i < names.Length; i++)
        {
            dict.Add(heights[i], names[i]);
        }
        //Bubble sort
        for(int i = 0; i<heights.Length-1; i++)
        {
            for(int j = 0; j<heights.Length-1-i; j++)
            {
                if (heights[j]<heights[j+1])
                {
                    int temp=heights[j];
                    heights[j]=heights[j+1];
                    heights[j+1]=temp;
                }
            }
        }
        for(int i = 0; i<heights.Length; i++)
        {
            names[i]=dict[heights[i]];
        }
        return names;

    }
}