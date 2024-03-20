class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FinalValueAfterOperations(new string[] { "--X", "X++", "X++" }));
        Console.WriteLine(FinalValueAfterOperations(new string[] { "++X", "++X", "X++" }));
    }
    public static int FinalValueAfterOperations(string[] operations)
    {
        int result = 0;
        foreach (string operation in operations)
        {
            //result= operation switch
            //{
            //    "X++" => result++,
            //    "++X" => result++,
            //    "--X" => result--,
            //    "X--" => result--,
            //    _ => result
            //};
            switch (operation)
            {
                case "X++":
                case "++X":
                    result++; break;
                case "--X":
                case "X--":
                    result--; break;
                default: result+=0; break;
            }
        }
        return result;
    }
}
