Console.WriteLine("Podaj maksymalną liczbę (n) do znalezienia liczb pierwszych:");
string input = Console.ReadLine();
int n = int.Parse(input);

if (n <= 1)
{
    Console.WriteLine("Proszę podać liczbę większą od 1.");
    return;
}

bool[] isPrime = new bool[n + 1];
for (int i = 2; i <= n; i++)
{
    isPrime[i] = true;
}

for (int p = 2; p * p <= n; p++)
{
    if (isPrime[p] == true)
    {
        for (int i = p * p; i <= n; i += p)
        {
            isPrime[i] = false;
        }
    }
}   

List<int> primeNumbers = new List<int>();
for (int i = 2; i <= n; i++)
{
    if (isPrime[i])
    {
        primeNumbers.Add(i);
    }
}

Console.WriteLine("Liczby pierwsze mniejsze lub równe " + n + ":");
Console.WriteLine(string.Join(", ", primeNumbers));
Console.WriteLine("Naciśnij ENTER, aby zakończyć");
Console.ReadLine();