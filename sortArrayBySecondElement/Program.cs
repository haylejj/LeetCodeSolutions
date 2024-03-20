class Program
{
    static void Main(string[] args)
    {
        string[] arr = new string[] { "b1", "c2", "a3", "x4", "z0" };

        sortArray(arr);

        static void sortArray(string[] arr)
        {
            string[] sortedArr = arr.OrderBy(x => x[1]).ToArray();

            foreach (string s in sortedArr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
