class Program
{
    static void Main(string[] args)
    {
        TimeRequiredToBuy(new int[] { 2, 3, 5, 6, 1, 3, 8, 6, 9 }, 2);
    }
    public static int TimeRequiredToBuy(int[] tickets, int k)
    {
        Queue<int> queue = new Queue<int>(tickets);
        int count = 0;
        while (true) {

            int ticket = queue.Dequeue()-1;
            count++;
            if(ticket==0 && k==0) return count;
            if(ticket>0) queue.Enqueue(ticket);
            if(k==0) k=queue.Count-1;
            else k--;
        }
    }
}