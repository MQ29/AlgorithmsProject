int numSamples = 1000000;
Random random = new Random();
int insideCircle = 0;

for (int i = 0; i < numSamples; i++)
{
    double x = random.NextDouble() * 2 - 1; 
    double y = random.NextDouble() * 2 - 1; 

    if (x * x + y * y <= 1)
    {
        insideCircle++;
    }
}

double piEstimate = 4.0 * insideCircle / numSamples;

Console.WriteLine($"Przybliżona wartość liczby pi: {piEstimate}");
Console.WriteLine("Naciśnij ENTER, aby zakończyć");
Console.ReadLine();
