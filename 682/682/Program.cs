class Program
{
    /*
     You are keeping the scores for a baseball game with strange rules. At the beginning of the game, you start with an empty record.

    You are given a list of strings operations, where operations[i] is the ith operation you must apply to the record and is one of the following:

    An integer x.
    Record a new score of x.
    '+'.
    Record a new score that is the sum of the previous two scores.
    'D'.
    Record a new score that is the double of the previous score.
    'C'.
    Invalidate the previous score, removing it from the record.
    Return the sum of all the scores on the record after applying all the operations.

    The test cases are generated such that the answer and all intermediate calculations fit in a 32-bit integer and that all operations are valid.
     */
    static void Main(string[] args)
    {
        Console.WriteLine(CalPoints(new string[] { "5", "2", "C", "D", "+" }));
    }
    public static int CalPoints(string[] operations)
    {
        int record = 0;
        Stack<string> stack = new Stack<string>(operations.Reverse());
        Stack<int> ints = new Stack<int>();
        while (stack.Count>0)
        {
            var operation=stack.Peek();
            if (operation=="D")
            {
                var temp = ints.Peek()*2;
                ints.Push(temp);
                stack.Pop();
            }
            else if (operation=="C")
            {
                ints.Pop();
                stack.Pop();
            }
            else if(operation=="+")
            {
                var temp1=ints.Pop();
                var temp2=ints.Pop();
                var temp = temp1+temp2;
                ints.Push(temp2);
                ints.Push(temp1);
                ints.Push(temp);
                stack.Pop();
            }
            else ints.Push(int.Parse(stack.Pop()));
        }
        while (ints.Count>0)
        {
            record+=ints.Pop();
        }
        return record;
    }
}