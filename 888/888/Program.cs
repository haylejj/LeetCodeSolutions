class Program
{
    static void Main(string[] args)
    {
        FairCandySwap(new int[] { 1, 2 }, new int[] { 2, 3 });
    }
    public static int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
    {
        //int aliceSum=aliceSizes.Sum();
        //int bobSum=bobSizes.Sum();
        //int[] result = new int[2];
        //for(int i = 0; i<aliceSizes.Length; i++)
        //{
        //    for(int j=0; j<bobSizes.Length; j++)
        //    {
        //            var temp1= aliceSizes[i];
        //            var temp2= bobSizes[j];
        //            if (aliceSum+temp2-temp1 == bobSum+temp1-temp2)
        //            {
        //                result[0] = temp1;
        //                result[1] = temp2;
        //                break;
        //            }
        //    }
        //}
        //return result;
        int aliceSum = aliceSizes.Sum();
        int bobSum = bobSizes.Sum();
        int differentSum = bobSum-aliceSum;
        for (int i = 0; i<aliceSizes.Length; i++)
        {
            // aliceSum - alice + bob == bobSum - bob + alice
            //2bob==differentSum+2alice
            //bob==differentSum+2alice/2
            int result = (differentSum+2*aliceSizes[i])/2;
            if (bobSizes.Contains(result))
            {
                return new int[] { aliceSizes[i], result };
            }
        }
        return new int[] { 0, 0 };
    }
}