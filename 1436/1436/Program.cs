class Program
{
    /*
     You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. Return the destination city, that is, the city without any path outgoing to another city.

    It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
     */
    static void Main(string[] args)
    {
        IList<IList<string>> paths = new List<IList<string>>
        {
            new List<string> { "pYyNGfBYbm","wxAscRuzOl" },
            new List<string> { "kzwEQHfwce","pYyNGfBYbm" },
        };
        Console.WriteLine(DestCity(paths));
    }
    public static string DestCity(IList<IList<string>> paths)
    {
        HashSet<string> startCities = new HashSet<string>();
        HashSet<string> destinationCities = new HashSet<string>();
        foreach (var item in paths)
        {
            startCities.Add(item[0]);
        }
        foreach (var item in paths)
        {
            if (!startCities.Contains(item[1]))
            {
                destinationCities.Add(item[1]);
            }
        }
        return destinationCities.First();
    }

}