double[,] distanceMatrix = {
            { 0, 29, 20, 21 },
            { 29, 0, 15, 17 },
            { 20, 15, 0, 28 },
            { 21, 17, 28, 0 }
        };

List<int> tour = NearestNeighbor(distanceMatrix);

double totalDistance = CalculateTotalDistance(tour, distanceMatrix);

Console.WriteLine("Optymalna trasa (algorytm najbliższego sąsiada):");
Console.WriteLine(string.Join(" -> ", tour.Select(city => city.ToString())));
Console.WriteLine($"Całkowita odległość: {totalDistance}");
Console.WriteLine("Naciśnij ENTER, aby zakończyć");
Console.ReadLine();

static List<int> NearestNeighbor(double[,] distanceMatrix)
{
    int numCities = distanceMatrix.GetLength(0);
    bool[] visited = new bool[numCities];
    List<int> tour = new List<int>();

    int currentCity = 0; 
    tour.Add(currentCity);
    visited[currentCity] = true;

    for (int i = 1; i < numCities; i++)
    {
        int nextCity = -1;
        double shortestDistance = double.MaxValue;

        for (int j = 0; j < numCities; j++)
        {
            if (!visited[j] && distanceMatrix[currentCity, j] < shortestDistance)
            {
                nextCity = j;
                shortestDistance = distanceMatrix[currentCity, j];
            }
        }

        tour.Add(nextCity);
        visited[nextCity] = true;
        currentCity = nextCity;
    }

    tour.Add(tour[0]);

    return tour;
}

static double CalculateTotalDistance(List<int> tour, double[,] distanceMatrix)
{
    double totalDistance = 0;

    for (int i = 0; i < tour.Count - 1; i++)
    {
        totalDistance += distanceMatrix[tour[i], tour[i + 1]];
    }

    return totalDistance;
}
