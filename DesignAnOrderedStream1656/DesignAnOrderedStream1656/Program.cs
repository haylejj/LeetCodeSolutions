using System.Text;

class Program
{
    /*
     There is a stream of n (idKey, value) pairs arriving in an arbitrary order, where idKey is an integer between 1 and n and value is a string. No two pairs have the same id.

    Design a stream that returns the values in increasing order of their IDs by returning a chunk (list) of values after each insertion. The concatenation of all the chunks should result in a list of the sorted values.

    Implement the OrderedStream class:

    OrderedStream(int n) Constructs the stream to take n values.
    List<string> Insert(int idKey, string value) Inserts the pair (idKey, value) into the stream, then returns the largest possible chunk of currently inserted values that appear next in the order.
     */
    
    private int ptr;
    private string[] stream;
    public Program(int n)
    {
        stream = new string[n];
        ptr = 0;
    }
    public List<string> Insert(int idKey, string value)
    {
        stream[idKey-1]=value;
        List<string> result= new List<string>();
        for(;ptr<stream.Length && stream[ptr]!=null;)
        {
            result.Add(stream[ptr]);
            ptr++;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Program pg= new Program(5);
        foreach (var item in pg.Insert(1, "aa"))
        {
            Console.WriteLine(item);
        }

        foreach (var item in pg.Insert(3, "cc"))
        {
            Console.WriteLine(item);
        }
        foreach (var item in pg.Insert(4,"dd"))
        {
            Console.WriteLine(item);
        }       
        foreach (var item in pg.Insert(5, "ee"))
        {
            Console.WriteLine(item);
        }
        foreach (var item in pg.Insert(2, "bb"))
        {
            Console.WriteLine(item);
        }
    }
}
