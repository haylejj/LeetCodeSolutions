class Program
{
    /*
     Given an integer array arr, return true if there are three consecutive odd numbers in the array. Otherwise, return false.
     */
    static void Main(string[] args)
    {

    }
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        for(int i = 0; i<arr.Length-2; i++)
        {
            if(arr[i]%2!=0 && arr[i+1]%2!=0 && arr[i+2]%2!=0)
                return true;
        }
        return false;
    }
}