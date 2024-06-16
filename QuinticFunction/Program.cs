Console.WriteLine("Podaj współczynniki a5, a4, a3, a2, a1, a0 w takiej kolejności oddzielone przecinkiem:");
string input = Console.ReadLine();

Console.WriteLine("Podaj wartość x:");
string inputX = Console.ReadLine();
double x = double.Parse(inputX);

string[] inputSplit = input.Split(',');
double[] coefficients = new double[inputSplit.Length];
for (int i = 0; i < inputSplit.Length; i++)
{
    coefficients[i] = Convert.ToDouble(inputSplit[i]);
}

if (coefficients.Length != 6)
{
    Console.WriteLine("Proszę podać dokładnie 6 współczynników.");
    return;
}

double a5 = coefficients[0];
double a4 = coefficients[1];
double a3 = coefficients[2];
double a2 = coefficients[3];
double a1 = coefficients[4];
double a0 = coefficients[5];

double result = a5;
result = result * x + a4;
result = result * x + a3;
result = result * x + a2;
result = result * x + a1;
result = result * x + a0;

Console.WriteLine($"Wartość wielomianu dla x = {x} wynosi: {result}");
Console.WriteLine("Naciśnij ENTER, aby zakończyć");
Console.ReadLine();
