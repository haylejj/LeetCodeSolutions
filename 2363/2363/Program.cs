using System.Collections;

class Program
{
    /*
     You are given two 2D integer arrays, items1 and items2, representing two sets of items. Each array items has the following properties:

    items[i] = [valuei, weighti] where valuei represents the value and weighti represents the weight of the ith item.
    The value of each item in items is unique.
    Return a 2D integer array ret where ret[i] = [valuei, weighti], with weighti being the sum of weights of all items with value valuei.

    Note: ret should be returned in ascending order by value.

 
     */
    static void Main(string[] args)
    {

    }
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
    {
        /*
        items1 =
        [[1,3],[2,2]]
        items2 =
        [[7,1],[2,2],[1,4]]
         */
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (var item in items1)
        {
            if (dict.ContainsKey(item[0])) dict[item[0]]+=item[1];
            else dict.Add(item[0], item[1]);
        }
        foreach (var item in items2)
        {
            if (dict.ContainsKey(item[0])) dict[item[0]]+=item[1];
            else dict.Add(item[0], item[1]);
        }
        List<IList<int>> result = new List<IList<int>>();
        foreach (var item in dict)
        {
            result.Add(new List<int> { item.Key, item.Value });
        }
        result.Sort((a, b) => a[0].CompareTo(b[0]));
        return result;
    }
}